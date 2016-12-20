using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using RealmOffline.Accounts;
using RealmOffline.Base;
using RealmOffline.Core;
using System.Data;
using RealmOffline.Core.Items;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Managers
{
    public class MySqlManager
    {
        #region Init
        private readonly static XMLManager xml = new XMLManager();
        public static bool IsInitialized = false;
        public static bool TestConnection
        {
            get
            {
                try
                {
                    using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                    {
                        c.Open();
                        IsInitialized = true;
                        Console.WriteLine("MySQL version : {0}", c.ServerVersion);
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            Console.WriteLine("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            Console.WriteLine("Invalid username/password, please try again");
                            break;
                        default:
                            Console.WriteLine("Unknown Error {0}", ex.Number);
                            break;
                    }
                    
                    return false;
                }
            }
        }
        #endregion
        #region User Checks
        /// <summary>
        /// Checks if a valid username and password was given
        /// </summary>
        /// <param name="userName">the username</param>
        /// <param name="passWord">the password</param>
        /// <returns>true if in mysql, false if not there.</returns>
        public static bool CheckLogin(string userName, string passWord)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM users WHERE Username='{0}'", userName), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int data = read.GetOrdinal("Password");
                        if (read.Read()) return PasswordHash.ValidatePassword(passWord, read.GetString(data));
                        else return false;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("CheckLogin {0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        /// <summary>
        /// Gets the auto incremented mysql id for this user
        /// </summary>
        /// <param name="userName">the username to look up</param>
        /// <returns>the int value of users id</returns>
        public static uint GetUserID(string userName)
        {
            if (!IsInitialized) { return 0; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM users WHERE Username='{0}'", userName), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int data = read.GetOrdinal("UserID");
                        while (read.Read())
                        {
                            return read.GetUInt32(data);
                        }
                        return 0;
                    }
                }
            }
            catch { return 0; }
        }
        /// <summary>
        /// Gets a users plevel
        /// </summary>
        /// <param name="userName">the username</param>
        /// <returns>the plevel</returns>
        public static int GetPLevel(uint sqlId)
        {
            if (!IsInitialized) { return -1; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Users WHERE UserID='{0}'", sqlId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int data = read.GetOrdinal("PLevel");
                        
                        if(read.Read())
                        {
                            return read.GetInt32(data);
                        }
                        return -1;
                    }
                }
            }
            catch { return -1; }
        }
        public static long GetAccountAge(uint sqlId)
        {
            if (!IsInitialized) { return -1; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Users WHERE UserID='{0}'", sqlId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int data = read.GetOrdinal("CreatedOn");

                        if (read.Read())
                        {
                            return read.GetInt64(data);
                        }
                        return -1;
                    }
                }
            }
            catch { return -1; }
        }
        #endregion
        #region Accounts
        public static bool CreateUserAccount(string username, string password, 
            string email, string secretword, int plevel, out string error)
        {
            error = string.Empty;
            if (!IsInitialized) { error = "Manager not Initialized"; return false; }
            // hash the password
            string hash = PasswordHash.CreateHash(password);
            password = hash;
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Users(UserID, Username, Password, Email, SecretWord, PLevel, CreatedOn) VALUES(@id, @user, @pass, @email, @word, @plvl, @date)", c))
                    {
                        cmd.Parameters.AddWithValue("@id", 0);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@word", secretword);
                        cmd.Parameters.AddWithValue("@plvl", plevel);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToBinary());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException x)
            {
                if (x.Number == 1062)
                {
                    error = string.Format("Username {0} in use.", username);
                }
                else Console.WriteLine(x.Message);
                return false;
            }
            catch (Exception ex) { Console.WriteLine("Create Account {0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public static bool DeleteUserAccount(string username)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM Users WHERE Username = '{0}'", username), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result != 0;
                    }
                }
            }
            catch { return false; }
        }
        public static bool ValidateAccount(string[] args, out string error)
        {
            bool valid = true;
            error = string.Empty;
            //string deleteUsage = "[Delete an Account]\n" +
            //  "account delete username";
            /* Do we have all the values we need ? we need a total of 7 arguments
                                    * 0 = account
                                    * 1 = create
                                    * 2 = username
                                    * 3 = password
                                    * 4 = email
                                    * 5 = secret
                                    * 6 = priv
                                    * for a total of 7 args
                                    */
            if (args.Length == 7)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == string.Empty)
                    {
                        error += string.Format("[No Value given for section {0}] ", i);
                        valid = false;
                    }
                }
                // Check the values
                // First value is username must be less than 16 total chars


                if (args[2].ToLower().Length > 16)
                {
                    error += "[Username needs to be under 16 total chars.] ";
                    valid = false;
                }
                if (args[3].ToLower().Length > 16)
                {
                    error += "[Password needs to be under 16 total chars.] ";
                    valid = false;
                }


                if (args[4].ToLower().Length > 100)
                {
                    error += "[Email needs to be under 100 total chars.] ";
                    valid = false;
                }
                if (args[5].ToLower().Length > 100)
                {
                    error += "[Secret Word needs to be under 100 total chars.] ";
                    valid = false;
                }
                int plevel = -1;

                if (int.TryParse(args[6], out plevel))
                {
                    // We are good, are we within the correct values ?
                    if (plevel > 5 || plevel < 0)
                    {
                        error += "[Valid values for PLevel are 0 - 5.] ";
                        valid = false;
                    }
                }
                if (valid)
                {
                    string er = string.Empty;
                    // Good work with it
                    bool created = MySqlManager.CreateUserAccount(args[2], args[3], args[4],
                        args[5], plevel, out er);
                    error += er;
                    return created;
                }
                else return valid;
            }
            else { return false; }
        }
        #endregion
        #region Characters
        public static bool SaveCharStats(Character c)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(xml.GetMySqlConnection))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = string.Format("UPDATE characters SET Strength = @str, " +
                            "Dexterity = @dex, Intelligence = @intell, Constitution = @con WHERE Id = @id");
                        cmd.Parameters.AddWithValue("@str", c.Strength);
                        cmd.Parameters.AddWithValue("@dex", c.Dexterity);
                        cmd.Parameters.AddWithValue("@intell", c.Intelligence);
                        cmd.Parameters.AddWithValue("@con", c.Constitution);
                        cmd.Parameters.AddWithValue("@id", c.SqlCharId);
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} {1}", ex.Message, ex.StackTrace);
            }
            return false;
        }
        public static List<Character> LoadCharactersFromAccount(uint accountId)
        {
            var reply = new List<Character>();
            if (!IsInitialized) { return reply; }
            
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Characters WHERE AccountID='{0}'", accountId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            var character = new Character();
                            character.SqlCharId = read.GetUInt32("Id");
                            //character.CharId = read.GetUInt32("CurrentID");
                            character.AccountOwnerId = read.GetUInt32("AccountID");
                            character.Name = read.GetString("CharName");
                            character.Class = (byte)read.GetUInt16("Class");
                            character.Race = (byte)read.GetUInt16("Race");
                            character.Gender = (byte)read.GetUInt16("Gender");
                            character.Strength = (byte)read.GetUInt16("Strength");
                            character.Dexterity = (byte)read.GetUInt16("Dexterity");
                            character.Intelligence = (byte)read.GetUInt16("Intelligence");
                            character.Constitution = (byte)read.GetUInt16("Constitution");
                            character.Alignment = (byte)read.GetUInt16("Alignment");
                            character.Invis = (byte)read.GetUInt16("Invis");
                            character.Girth = (byte)read.GetUInt16("Girth");
                            character.Height = (byte)read.GetUInt16("Height");
                            character.RaceHead = (byte)read.GetUInt16("RaceHead");
                            character.HeadPart = (byte)read.GetUInt16("HeadPart");
                            character.ChinPart = (byte)read.GetUInt16("ChinPart");
                            character.HairPart = (byte)read.GetUInt16("HairPart");
                            character.EyeBrowPart = (byte)read.GetUInt16("EyeBrowPart");
                            character.EyePart = (byte)read.GetUInt16("EyePart");
                            character.NosePart = (byte)read.GetUInt16("NosePart");
                            character.EarPart = (byte)read.GetUInt16("EarPart");
                            character.MouthPart = (byte)read.GetUInt16("MouthPart");
                            character.FacialHairPart = (byte)read.GetUInt16("FacialHairPart");
                            character.SkinColor = (byte)read.GetUInt16("SkinColor");
                            character.HairColor = (byte)read.GetUInt16("HairColor");
                            character.EyeColor = (byte)read.GetUInt16("EyeColor");
                            character.Title = read.GetString("Title");
                            character.PvpSwitch = (byte)read.GetUInt16("Pvp");
                            character.Biography = read.GetString("Biography");
                            character.Gold = read.GetInt32("Gold");
                            character.Mana = read.GetInt32("Mana");
                            character.Level = read.GetUInt16("Level");
                            character.CurrentHP = read.GetInt32("CurrentHP");
                            character.TotalHP = read.GetInt32("TotalHP");
                            character.BuildPoints = read.GetUInt16("BuildPoints");
                            character.CurrentXP = read.GetUInt16("CurrentXP");
                            if (read.GetUInt16("IsMob") == 1)
                            {
                                // Need this for saftey
                                character.SwitchCharacterToMob(read.GetInt16("MobGraphic"));
                            }
                            character.CharDataAdded = true;
                            character.PartDataAdded = true;
                            character.DescriptionAdded = true;
                            reply.Add(character);
                        }
                        return reply;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return reply; }
        }
        public static Character GetCharacter(uint sqlID)
        {
            if (!IsInitialized) { return null; }
            Character character = null;
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Characters WHERE Id={0}", sqlID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            character= new Character();
                            character.SqlCharId = read.GetUInt32("Id");
                          //  character.CharId = read.GetUInt32("CurrentID");
                            character.AccountOwnerId = read.GetUInt32("AccountID");
                            character.Name = read.GetString("CharName");
                            character.Class = (byte)read.GetUInt16("Class");
                            character.Race = (byte)read.GetUInt16("Race");
                            character.Gender = (byte)read.GetUInt16("Gender");
                            character.Strength = (byte)read.GetUInt16("Strength");
                            character.Dexterity = (byte)read.GetUInt16("Dexterity");
                            character.Intelligence = (byte)read.GetUInt16("Intelligence");
                            character.Constitution = (byte)read.GetUInt16("Constitution");
                            character.Alignment = (byte)read.GetUInt16("Alignment");
                            character.Invis = (byte)read.GetUInt16("Invis");
                            character.Girth = (byte)read.GetUInt16("Girth");
                            character.Height = (byte)read.GetUInt16("Height");
                            character.RaceHead = (byte)read.GetUInt16("RaceHead");
                            character.HeadPart = (byte)read.GetUInt16("HeadPart");
                            character.ChinPart = (byte)read.GetUInt16("ChinPart");
                            character.HairPart = (byte)read.GetUInt16("HairPart");
                            character.EyeBrowPart = (byte)read.GetUInt16("EyeBrowPart");
                            character.EyePart = (byte)read.GetUInt16("EyePart");
                            character.NosePart = (byte)read.GetUInt16("NosePart");
                            character.EarPart = (byte)read.GetUInt16("EarPart");
                            character.MouthPart = (byte)read.GetUInt16("MouthPart");
                            character.FacialHairPart = (byte)read.GetUInt16("FacialHairPart");
                            character.SkinColor = (byte)read.GetUInt16("SkinColor");
                            character.HairColor = (byte)read.GetUInt16("HairColor");
                            character.EyeColor = (byte)read.GetUInt16("EyeColor");
                            character.Title = read.GetString("Title");
                            character.PvpSwitch = (byte)read.GetUInt16("Pvp");
                            character.Biography = read.GetString("Biography");
                            character.Gold = read.GetInt32("Gold");
                            character.Mana = read.GetInt32("Mana");
                            character.Level = read.GetUInt16("Level");
                            character.CurrentHP = read.GetInt32("CurrentHP");
                            character.TotalHP = read.GetInt32("TotalHP");
                            character.BuildPoints = read.GetUInt16("BuildPoints");
                            character.CurrentXP = read.GetUInt16("CurrentXP");
                            if (read.GetUInt16("IsMob") == 1)
                            {
                                // Need this for saftey
                                character.SwitchCharacterToMob(read.GetInt16("MobGraphic"));
                            }
                            character.CharDataAdded = true;
                            character.PartDataAdded = true;
                            character.DescriptionAdded = true;
                        }
                        return character;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }
        public static Character GetCurrentCharacter(uint charID)
        {
            if (!IsInitialized) { return null; }
            Character character = null;
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Characters WHERE CurrentID={0}", charID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            character = new Character();
                            character.SqlCharId = read.GetUInt32("Id");
                           // character.CharId = read.GetUInt32("CurrentID");
                            character.AccountOwnerId = read.GetUInt32("AccountID");
                            character.Name = read.GetString("CharName");
                            character.Class = (byte)read.GetUInt16("Class");
                            character.Race = (byte)read.GetUInt16("Race");
                            character.Gender = (byte)read.GetUInt16("Gender");
                            character.Strength = (byte)read.GetUInt16("Strength");
                            character.Dexterity = (byte)read.GetUInt16("Dexterity");
                            character.Intelligence = (byte)read.GetUInt16("Intelligence");
                            character.Constitution = (byte)read.GetUInt16("Constitution");
                            character.Alignment = (byte)read.GetUInt16("Alignment");
                            character.Invis = (byte)read.GetUInt16("Invis");
                            character.Girth = (byte)read.GetUInt16("Girth");
                            character.Height = (byte)read.GetUInt16("Height");
                            character.RaceHead = (byte)read.GetUInt16("RaceHead");
                            character.HeadPart = (byte)read.GetUInt16("HeadPart");
                            character.ChinPart = (byte)read.GetUInt16("ChinPart");
                            character.HairPart = (byte)read.GetUInt16("HairPart");
                            character.EyeBrowPart = (byte)read.GetUInt16("EyeBrowPart");
                            character.EyePart = (byte)read.GetUInt16("EyePart");
                            character.NosePart = (byte)read.GetUInt16("NosePart");
                            character.EarPart = (byte)read.GetUInt16("EarPart");
                            character.MouthPart = (byte)read.GetUInt16("MouthPart");
                            character.FacialHairPart = (byte)read.GetUInt16("FacialHairPart");
                            character.SkinColor = (byte)read.GetUInt16("SkinColor");
                            character.HairColor = (byte)read.GetUInt16("HairColor");
                            character.EyeColor = (byte)read.GetUInt16("EyeColor");
                            character.Title = read.GetString("Title");
                            character.PvpSwitch = (byte)read.GetUInt16("Pvp");
                            character.Biography = read.GetString("Biography");
                            character.Gold = read.GetInt32("Gold");
                            character.Mana = read.GetInt32("Mana");
                            character.Level = read.GetUInt16("Level");
                            character.CurrentHP = read.GetInt32("CurrentHP");
                            character.TotalHP = read.GetInt32("TotalHP");
                            character.BuildPoints = read.GetUInt16("BuildPoints");
                            character.CurrentXP = read.GetUInt16("CurrentXP");
                            if (read.GetUInt16("IsMob") == 1)
                            {
                                // Need this for saftey
                                character.SwitchCharacterToMob(read.GetInt16("MobGraphic"));
                            }
                            character.CharDataAdded = true;
                            character.PartDataAdded = true;
                            character.DescriptionAdded = true;
                        }
                        return character;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }
        public static bool CreateNewCharacter(Character c, uint sqlAccountId, out uint sqlcharID)
        {
            bool charCreated = false;
            sqlcharID = 0;
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(xml.GetMySqlConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Characters VALUES(@Id, @aid, @name, @class, @race, @gender, @str, @dex, @int, @con, @align, @invis, @girth, @height,"+
                            "@racehead, @headpart, @chinpart, " +
                            "@hairpart, @browpart, @eyepart, @nosepart, @earpart, @mouthpart, @facehairpart, @skincolor, @haircolor, @eyecolor, " +
                            "@title, @pvp, @bio, @gold, @mana, @level, @currenthp, @totalhp, @buildpoints, @currentxp, @ismob, @mobgraphic)";
                        cmd.Parameters.AddWithValue("@Id", 0);
                        cmd.Parameters.AddWithValue("@aid", sqlAccountId);
                        cmd.Parameters.AddWithValue("@name", c.Name);
                        cmd.Parameters.AddWithValue("@class", c.Class);
                        cmd.Parameters.AddWithValue("@race", c.Race);
                        cmd.Parameters.AddWithValue("@gender", c.Gender);
                        cmd.Parameters.AddWithValue("@str", c.Strength);
                        cmd.Parameters.AddWithValue("@dex", c.Dexterity);
                        cmd.Parameters.AddWithValue("@int", c.Intelligence);
                        cmd.Parameters.AddWithValue("@con", c.Constitution);
                        cmd.Parameters.AddWithValue("@align", c.Alignment);
                        cmd.Parameters.AddWithValue("@invis", c.Invis);
                        cmd.Parameters.AddWithValue("@girth", c.Girth);
                        cmd.Parameters.AddWithValue("@height", c.Height);
                        cmd.Parameters.AddWithValue("@racehead", c.RaceHead);
                        cmd.Parameters.AddWithValue("@headpart", c.HeadPart);
                        cmd.Parameters.AddWithValue("@chinpart", c.ChinPart);
                        cmd.Parameters.AddWithValue("@hairpart", c.HairPart);
                        cmd.Parameters.AddWithValue("@browpart", c.EyeBrowPart);
                        cmd.Parameters.AddWithValue("@eyepart", c.EyePart);
                        cmd.Parameters.AddWithValue("@nosepart", c.NosePart);
                        cmd.Parameters.AddWithValue("@earpart", c.EarPart);
                        cmd.Parameters.AddWithValue("@mouthpart", c.MouthPart);
                        cmd.Parameters.AddWithValue("@facehairpart", c.FacialHairPart);
                        cmd.Parameters.AddWithValue("@skincolor", c.SkinColor);
                        cmd.Parameters.AddWithValue("@haircolor", c.HairColor);
                        cmd.Parameters.AddWithValue("@eyecolor", c.EyeColor);
                        cmd.Parameters.AddWithValue("@title", c.Title);
                        cmd.Parameters.AddWithValue("@pvp", c.PvpSwitch);
                        cmd.Parameters.AddWithValue("@bio", c.Biography);
                        cmd.Parameters.AddWithValue("@gold", c.Gold);
                        cmd.Parameters.AddWithValue("@mana", c.Mana);
                        cmd.Parameters.AddWithValue("@level", c.Level);
                        cmd.Parameters.AddWithValue("@currenthp", c.CurrentHP);
                        cmd.Parameters.AddWithValue("@totalhp", c.TotalHP);
                        cmd.Parameters.AddWithValue("@buildpoints", c.BuildPoints);
                        cmd.Parameters.AddWithValue("@currentxp", c.CurrentXP);
                        cmd.Parameters.AddWithValue("@ismob", c.IsMob ?  1:0);
                        cmd.Parameters.AddWithValue("@mobgraphic", c.MobGraphic);
                        cmd.ExecuteNonQuery();
                        c.SqlCharId= (uint)cmd.LastInsertedId;
                        sqlcharID = c.SqlCharId;
                        charCreated = true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }

            
            // Characters db portion done
            CharacterSkills skills = new CharacterSkills(c.SqlCharId);
            bool skillsAdded = skills.CreateNewSkillsSetByClass(c.Class, c.Alignment);
            CharacterSpells spells = new CharacterSpells(c.SqlCharId);
            bool spellsAdded = spells.CreateNewSpellsSetByClass(c.Class, c.Alignment);
            CharacterAffects affects = new CharacterAffects(c.SqlCharId);
            bool affectsAdded = affects.CreateNewAffectsForChar();
            CharacterStates states = new CharacterStates(c.SqlCharId);
            bool statesAdded = states.CreateNewStates();

            return charCreated && skillsAdded && spellsAdded && affectsAdded && statesAdded;
        }
        #region TryCharUpdates
        public static bool TryUpdateCharValue(string sqlValue, string newValue, uint sqlCharId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE characters SET {0} = '{1}' WHERE Id = {2}",
                        sqlValue, newValue, sqlCharId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool TryUpdateCharValue(string sqlValue, byte newValue, uint sqlCharId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE characters SET {0} = {1} WHERE Id = {2}",
                        sqlValue, newValue, sqlCharId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool TryUpdateCharValue(string sqlValue, ulong newValue, uint sqlCharId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE characters SET {0} = {1} WHERE Id = {2}",
                        sqlValue, newValue, sqlCharId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool TryUpdateCharValue(string sqlValue, uint newValue, uint sqlCharId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE characters SET {0} = {1} WHERE Id = {2}",
                        sqlValue, newValue, sqlCharId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        #endregion
        public static bool DeleteCharacter(Character character)
        {
            if (!IsInitialized) { return false; }
            if (character == null) { Console.WriteLine("This char is null"); }
            else Console.WriteLine("We want to delete sql id {0}", character.SqlCharId);
            // Delete Affects first
            bool affects = MySqlManager.DeleteAffects(character.SqlCharId);
            Console.WriteLine("Affects Delete {0}", affects ? "Success!":"Failure!!");
            // Delete Spells
            bool spells = MySqlManager.DeleteSpells(character.SqlCharId);
            Console.WriteLine("Spells Delete {0}", spells ? "Success!" : "Failure!!");
            // Delete Skills
            bool skills = MySqlManager.DeleteSkills(character.SqlCharId);
            Console.WriteLine("Skills Delete {0}", skills ? "Success!" : "Failure!!");

            bool states = MySqlManager.DeleteStates(character.SqlCharId);
            Console.WriteLine("States Delete {0}", states ? "Success!" : "Failure!!");
            
            // remove all inventory here
            //Item[] items = LoadItems(character.SqlCharId);

            foreach (Item i in character.Inventory)
            {
                bool del = DeleteItem(i.SqlID);
                if (!del) Console.WriteLine("Error removing item {0} from database!", i.GameID); 
            }
            // Remove Magic mails

            Console.WriteLine("Getting mail char null ? {0}", character == null);
            List<Mail> mails = LoadMail(character.SqlCharId);
            Console.WriteLine("Got {0} mails.", mails.Count);
            
            for (int m = 0; m < mails.Count; m++)
            {
                bool d = DeleteMail(character.SqlCharId, mails[m].MailID);
                Console.WriteLine("Mails Delete {0}", d ? "Success!" : "Failure!!");
            }
            // Finnaly remove the char
            bool charRemoved = false;
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("DELETE FROM Characters WHERE Id = '{0}'",
                        character.SqlCharId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        charRemoved = result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); charRemoved = false; ; }
            Console.WriteLine("Char Delete {0}", charRemoved ? "Success!" : "Failure!!");
            return affects && spells && skills && charRemoved && states;
        }
        public static bool IsNameTaken(string name)
        {
            if (!IsInitialized) { return false; }
            bool valid = false;
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd  = 
                    new MySqlCommand(string.Format("SELECT * FROM Characters WHERE Charname = '{0}';",
                        name), c))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        
                            valid = reader.HasRows;
                        
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return valid;
        }
        public static bool TryFindCharacter(string name, out uint sqlID)
        {
            sqlID = 0;
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("SELECT * FROM Characters WHERE Charname = '{0}'",
                        name), c))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            sqlID = reader.GetUInt32("Id");
                        }
                        return reader.HasRows && sqlID != 0;

                    }
                }
            }
            catch (Exception) { return false; }
        }
        #endregion
        #region Skills
        /// <summary>
        /// Loads character skills from the database by charid
        /// </summary>
        /// <param name="charId">the charid</param>
        /// <returns>all skill values</returns>
        public static CharacterSkills LoadSkills(uint charId)
        {
            CharacterSkills reply = null;
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Skills WHERE CharID='{0}'", charId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (!read.HasRows) { return null; }
                        while (read.Read())
                        {
                            reply = new CharacterSkills(charId);
                            reply.Short_Sword = (byte)read.GetUInt16("Short_Sword");
                            reply.Long_Sword = (byte)read.GetUInt16("Long_Sword");
                            reply.Two_Handed = (byte)read.GetUInt16("Two_Handed");
                            reply.Dagger = (byte)read.GetUInt16("Dagger");
                            reply.Axe = (byte)read.GetUInt16("Axe");
                            reply.Club = (byte)read.GetUInt16("Club");
                            reply.Mace = (byte)read.GetUInt16("Mace");
                            reply.Unarmed_Combat = (byte)read.GetUInt16("Unarmed_Combat");
                            reply.Throwing = (byte)read.GetUInt16("Throwing");
                            reply.Acrobatics = (byte)read.GetUInt16("Acrobatics");
                            reply.Maul = (byte)read.GetUInt16("Maul");
                            reply.Sorcery = (byte)read.GetUInt16("Sorcery");
                            reply.Elementalism = (byte)read.GetUInt16("Elementalism");
                            reply.Mysticism = (byte)read.GetUInt16("Mysticism");
                            reply.Thamaturgy = (byte)read.GetUInt16("Thaumaturgy");
                            reply.Necromancy = (byte)read.GetUInt16("Necromancy");
                            reply.Theurgism = (byte)read.GetUInt16("Theurgism");
                            reply.Alchemy = (byte)read.GetUInt16("Alchemy");
                            reply.Weaponsmith = (byte)read.GetUInt16("Weaponsmith");
                            reply.Armorsmith = (byte)read.GetUInt16("Armorsmith");
                            reply.Unknown1 = (byte)read.GetUInt16("Unknown1");
                            reply.Unknown2 = (byte)read.GetUInt16("Unknown2");
                            reply.Unknown3 = (byte)read.GetUInt16("Unknown3");
                            reply.Unknown4 = (byte)read.GetUInt16("Unknown4");
                            reply.Unknown5 = (byte)read.GetUInt16("Unknown5");
                            reply.Pickpocketing = (byte)read.GetUInt16("Pickpocketing");
                            reply.Disarm_Traps = (byte)read.GetUInt16("Disarm_Traps");
                            reply.Lockpicking = (byte)read.GetUInt16("Lockpicking");
                            reply.Meditation = (byte)read.GetUInt16("Meditation");
                            reply.Critical_Strike = (byte)read.GetUInt16("Critical_Strike");
                            reply.Shield_Usage = (byte)read.GetUInt16("Shield_Usage");
                            reply.Crafting = (byte)read.GetUInt16("Crafting");
                        }
                        return reply;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log it
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool SetSkill(uint charId, string skillName, int value)
        {
            if (value > 255) { value = 255; }// Cant be larger than 255
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("UPDATE Skills SET {0} = '{1}' WHERE CharID='{2}'",
                        skillName, value, charId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool InsertNewSkills(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO Skills(CharID) VALUES({0})",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool DeleteSkills(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("DELETE FROM Skills WHERE CharID = '{0}'",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool HasSkills(uint charId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Skills WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        return read.HasRows;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool PlayerHasSkill(uint charId, string skillName)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Skills WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int reply = 0;
                        while (read.Read())
                        {
                            reply = read.GetUInt16(skillName);
                        }
                        return reply == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        #endregion
        #region Spells
        /// <summary>
        /// Loads character skills from the database by charid
        /// </summary>
        /// <param name="charId">the charid</param>
        /// <returns>all skill values</returns>
        public static CharacterSpells LoadSpells(uint charId)
        {
            CharacterSpells reply = new CharacterSpells(charId);
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Spells WHERE CharID={0}", charId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        //if (!read.HasRows) { return null; }
                        while (read.Read())
                        {
                            
                            reply.Home = (byte)read.GetUInt16("Home");
                            reply.Killstar = (byte)read.GetUInt16("Killstar");
                            reply.Unlock = (byte)read.GetUInt16("Unlock_Spell");
                            reply.Dispell_Magic = (byte)read.GetUInt16("Dispell_Magic");
                            reply.Engrave = (byte)read.GetUInt16("Engrave");
                            reply.Multiblade = (byte)read.GetUInt16("Multiblade");
                            reply.Gather_The_Fellowship = (byte)read.GetUInt16("Gather_The_Fellowship");
                            reply.Cornucopia = (byte)read.GetUInt16("Cornucopia");
                            reply.Cloud_Of_Fog = (byte)read.GetUInt16("Cloud_Of_Fog");
                            reply.Improve_Armor = (byte)read.GetUInt16("Improve_Armor");
                            reply.Teleport = (byte)read.GetUInt16("Teleport");
                            reply.Extention = (byte)read.GetUInt16("Extention");
                            reply.Invisibility_See = (byte)read.GetUInt16("Invisibility_See");
                            reply.Shift = (byte)read.GetUInt16("Shift");
                            reply.Invisibility = (byte)read.GetUInt16("Invisibility");
                            reply.Teleport_Combat = (byte)read.GetUInt16("Teleport_Combat");
                            reply.Teleport_Group = (byte)read.GetUInt16("Teleport_Group");
                            reply.Permanency = (byte)read.GetUInt16("Permanency");
                            reply.Rust = (byte)read.GetUInt16("Rust");
                            reply.Defencelessness = (byte)read.GetUInt16("Defencelessness");
                            reply.Invisibility_Improved = (byte)read.GetUInt16("Invisibility_Improved");
                            reply.Enchant_Item = (byte)read.GetUInt16("Enchant_Item");
                            reply.Mass_Rust = (byte)read.GetUInt16("Mass_Rust");
                            reply.Elphames_Justice = (byte)read.GetUInt16("Elphames_Justice");
                            reply.Fire_Grasp = (byte)read.GetUInt16("Fire_Grasp");
                            reply.Flame_Orb = (byte)read.GetUInt16("Flame_Orb");
                            reply.Arctic_Grasp = (byte)read.GetUInt16("Arctic_Grasp");
                            reply.Ice_Orb = (byte)read.GetUInt16("Ice_Orb");
                            reply.Earth_Spike = (byte)read.GetUInt16("Earth_Spike");
                            reply.Incinerate = (byte)read.GetUInt16("Incinerate");
                            reply.Gust_Of_Wind = (byte)read.GetUInt16("Gust_Of_Wind");
                            reply.Immolation = (byte)read.GetUInt16("Immolation");
                            reply.Dancing_Flame = (byte)read.GetUInt16("Dancing_Flame");
                            reply.Flame_Blade = (byte)read.GetUInt16("Flame_Blade");
                            reply.Electric_Charge = (byte)read.GetUInt16("Electric_Charge");
                            reply.Cold_Steel = (byte)read.GetUInt16("Cold_Steel");
                            reply.Sandstorm = (byte)read.GetUInt16("Sandstorm");
                            reply.Spark = (byte)read.GetUInt16("Spark");
                            reply.Ice_Storm = (byte)read.GetUInt16("Ice_Storm");
                            reply.Freezing_Wind = (byte)read.GetUInt16("Freezing_Wind");
                            reply.Hurricane = (byte)read.GetUInt16("Hurricane");
                            reply.Crawling_Charge = (byte)read.GetUInt16("Crawling_Charge");
                            reply.Stoning = (byte)read.GetUInt16("Stoning");
                            reply.Fireball = (byte)read.GetUInt16("Fireball");
                            reply.Lightning_Bolt = (byte)read.GetUInt16("Lightning_Bolt");
                            reply.Freeze = (byte)read.GetUInt16("Freeze");
                            reply.Crushing_Boulder = (byte)read.GetUInt16("Crushing_Boulder");
                            reply.Electric_Fury = (byte)read.GetUInt16("Electric_Fury");
                            reply.Cold_Snap = (byte)read.GetUInt16("Cold_Snap");
                            reply.Earth_Quake = (byte)read.GetUInt16("Earthquake");
                            reply.Despothes_Wrath = (byte)read.GetUInt16("Despothes_Wrath");
                            reply.Hold_Monster = (byte)read.GetUInt16("Hold_Monster");
                            reply.Fumble = (byte)read.GetUInt16("Fumble");
                            reply.Psychic_Orb = (byte)read.GetUInt16("Psychic_Orb");
                            reply.Confusion = (byte)read.GetUInt16("Confusion");
                            reply.Forget = (byte)read.GetUInt16("Forget");
                            reply.Mind_Shackle = (byte)read.GetUInt16("Mind_Shackle");
                            reply.Identify = (byte)read.GetUInt16("Identify");
                            reply.Berzerk = (byte)read.GetUInt16("Berzerk");
                            reply.Stun = (byte)read.GetUInt16("Stun");
                            reply.Loyalty_Shift = (byte)read.GetUInt16("Loyalty_Shift");
                            reply.Warp_Mind = (byte)read.GetUInt16("Warp_Mind");
                            reply.Etherealize = (byte)read.GetUInt16("Etherealize");
                            reply.Spell_Blast = (byte)read.GetUInt16("Spell_Blast");
                            reply.Mass_Hold = (byte)read.GetUInt16("Mass_Hold");
                            reply.Unknown1 = (byte)read.GetUInt16("Unknown1");
                            reply.Mass_Fumble = (byte)read.GetUInt16("Mass_Fumble");
                            reply.Fear = (byte)read.GetUInt16("Fear");
                            reply.Iron_Chains = (byte)read.GetUInt16("Iron_Chains");
                            reply.Mass_Berzerk = (byte)read.GetUInt16("Mass_Berserk");
                            reply.Mass_Stun = (byte)read.GetUInt16("Mass_Stun");
                            reply.Mass_Loyalty_Shift = (byte)read.GetUInt16("Mass_Loyalty_Shift");
                            reply.Mabons_Forced_Flee = (byte)read.GetUInt16("Mabons_Forced_Flee");
                            reply.Illusionary_Foe = (byte)read.GetUInt16("Illusionary_Foe");
                            reply.Anti_Magic_Aura = (byte)read.GetUInt16("Anti_Magic_Aura");
                            reply.Light_Dart = (byte)read.GetUInt16("Light_Dart");
                            reply.Curse_Of_Clumsiness = (byte)read.GetUInt16("Curse_Of_Clumsiness");
                            reply.Nimbility = (byte)read.GetUInt16("Nimbility");
                            reply.Empower = (byte)read.GetUInt16("Empower");
                            reply.Enfeeble = (byte)read.GetUInt16("Enfeeble");
                            reply.Missle_Resistance = (byte)read.GetUInt16("Missle_Resistance");
                            reply.Heal = (byte)read.GetUInt16("Heal");
                            reply.Summon_Pixie = (byte)read.GetUInt16("Summon_Pixie");
                            reply.Purify = (byte)read.GetUInt16("Purify");
                            reply.Cure_Poison = (byte)read.GetUInt16("Cure_Poison");
                            reply.Unknown2 = (byte)read.GetUInt16("Unknown2");
                            reply.Heal_Greater = (byte)read.GetUInt16("Heal_Greater");
                            reply.Remove_Curse = (byte)read.GetUInt16("Remove_Curse");
                            reply.Summon_Fairy = (byte)read.GetUInt16("Summon_Fairy");
                            reply.Curse_Fire = (byte)read.GetUInt16("Curse_Fire");
                            reply.Curse_Cold = (byte)read.GetUInt16("Curse_Cold");
                            reply.Curse_Electric = (byte)read.GetUInt16("Curse_Electric");
                            reply.Shield = (byte)read.GetUInt16("Shield");
                            reply.Shield_Greater = (byte)read.GetUInt16("Shield_Greater");
                            reply.Wrath_Of_The_Gods = (byte)read.GetUInt16("Wrath_Of_The_Gods");
                            reply.Shield_Fire = (byte)read.GetUInt16("Shield_Fire");
                            reply.Shield_Cold = (byte)read.GetUInt16("Shield_Cold");
                            reply.Shield_Lightning = (byte)read.GetUInt16("Shield_Lightning");
                            reply.Summon_Nymph = (byte)read.GetUInt16("Summon_Nymph");
                            reply.Regeneration = (byte)read.GetUInt16("Regeneration");
                            reply.Indestruction = (byte)read.GetUInt16("Indestruction");
                            reply.Invulnerability = (byte)read.GetUInt16("Invulnerability");
                            reply.Enids_Blessing = (byte)read.GetUInt16("Enids_Blessing");
                            reply.Banishment = (byte)read.GetUInt16("Banishment");
                            reply.Summon_Fairy_Queen = (byte)read.GetUInt16("Summon_Fairy_Queen");
                            reply.Acid_Sphere = (byte)read.GetUInt16("Acid_Sphere");
                            reply.Venomous_Touch = (byte)read.GetUInt16("Venomous_Touch");
                            reply.Unknown3 = (byte)read.GetUInt16("Unknown3");
                            reply.Poison_Bolt = (byte)read.GetUInt16("Poison_Bolt");
                            reply.Unknown4 = (byte)read.GetUInt16("Unknown4");
                            reply.Drain_Life = (byte)read.GetUInt16("Drain_Life");
                            reply.Acid_Cloud = (byte)read.GetUInt16("Acid_Cloud");
                            reply.Summon_Zombie = (byte)read.GetUInt16("Summon_Zombie");
                            reply.Venom = (byte)read.GetUInt16("Venom");
                            reply.Summon_Undead = (byte)read.GetUInt16("Summon_Undead");
                            reply.Acid_Rain = (byte)read.GetUInt16("Acid_Rain");
                            reply.Night_Friends = (byte)read.GetUInt16("Night_Friends");
                            reply.Steal_Life = (byte)read.GetUInt16("Steal_Life");
                            reply.Unknown5 = (byte)read.GetUInt16("Unknown5");
                            reply.Summon_Doppleganger = (byte)read.GetUInt16("Summon_Doppleganger");
                            reply.Death_Touch = (byte)read.GetUInt16("Death_Touch");
                            reply.Banish = (byte)read.GetUInt16("Banish");
                            reply.Shadow_Warrior = (byte)read.GetUInt16("Shadow_Warrior");
                            reply.Summon_Daemon = (byte)read.GetUInt16("Summon_Daemon");
                            reply.Duachs_Vengence = (byte)read.GetUInt16("Duachs_Vengence");
                            reply.Death_Wish = (byte)read.GetUInt16("Death_Wish");
                            reply.Mass_Drain = (byte)read.GetUInt16("Mass_Drain");
                            reply.Curse_Poison = (byte)read.GetUInt16("Curse_Poison");
                            reply.Curse_Acid = (byte)read.GetUInt16("Curse_Acid");
                            reply.Shield_Poison = (byte)read.GetUInt16("Shield_Poison");
                            reply.Shield_Acid = (byte)read.GetUInt16("Shield_Acid");
                            reply.Head_Of_Death = (byte)read.GetUInt16("Head_Of_Death");
                            reply.Identify_Greater = (byte)read.GetUInt16("Identify_Greater");
                            reply.Summon_Monster_I = (byte)read.GetUInt16("Summon_Monster_I");
                            reply.Summon_Monster_II = (byte)read.GetUInt16("Summon_Monster_II");
                            reply.Summon_Monster_III = (byte)read.GetUInt16("Summon_Monster_III");
                            reply.Summon_Ratling = (byte)read.GetUInt16("Summon_Ratling");
                            reply.Summon_Bat = (byte)read.GetUInt16("Summon_Bat");
                            reply.Summon_Fenris = (byte)read.GetUInt16("Summon_Fenris");
                            reply.Summon_Imp = (byte)read.GetUInt16("Summon_Imp");
                            reply.Summon_Orge = (byte)read.GetUInt16("Summon_Orge");
                            reply.Summon_Troll = (byte)read.GetUInt16("Summon_Troll");
                            reply.Summon_Seraph = (byte)read.GetUInt16("Summon_Seraph");
                            reply.Unknown6 = (byte)read.GetUInt16("Unknown6");
                            reply.Unknown7 = (byte)read.GetUInt16("Unknown7");
                            reply.Unknown8 = (byte)read.GetUInt16("Unknown8");
                            reply.Unknown9 = (byte)read.GetUInt16("Unknown9");
                            reply.Unknown10 = (byte)read.GetUInt16("Unknown10");
                            reply.Heal_Mass = (byte)read.GetUInt16("Heal_Mass");
                            reply.Unknown11 = (byte)read.GetUInt16("Unknown11");
                        }
                        return reply;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log it
                Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace);
            }
            return reply;
        }
        /// <summary>
        /// Gives or takes a spell from a player
        /// </summary>
        /// <param name="charId">the char id to do this too</param>
        /// <param name="spellName">the spellname to give or take away</param>
        /// <param name="giveOrTakeSpell">true to give a spell, false to remove it</param>
        /// <returns>true if record exists and was changed</returns>
        public static bool GiveSpell(uint charId, string spellName, bool giveOrTakeSpell = true)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("UPDATE Spells SET {0} ={1} WHERE CharID={2}",
                        spellName, giveOrTakeSpell ? 1:0, charId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public static bool InsertNewSpells(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO Spells(CharID) VALUES({0})",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static List<string> GetSpellNames()
        {
            List<string> names = new List<string>();
            DataTable s = null;
             if (!IsInitialized) { return names; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM spells"), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly);
                        s = read.GetSchemaTable();
                    }
                    foreach (DataRow col in s.Rows)
                    {
                        names.Add(col.Field<String>("ColumnName"));
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1} ", ex.StackTrace, ex.Message); }
            return names;
        }
        public static bool DeleteSpells(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("DELETE FROM Spells WHERE CharID = '{0}'",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool HasSpells(uint charId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Spells WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        return read.HasRows;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool PlayerHasSpell(uint charId, string spellName)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Spells WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int reply = 0;
                        while (read.Read())
                        {
                            reply = read.GetUInt16(spellName);
                        }
                        return reply == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        #endregion
        #region CharAffects
        public static CharacterAffects LoadAffects(uint charId)
        {
            CharacterAffects reply = null;
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Affects WHERE CharID='{0}'", charId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (!read.HasRows) { return null; }
                        while (read.Read())
                        {
                            reply = new CharacterAffects(charId);
                            reply.Unarmed_Attack_Fire = (byte)read.GetUInt16("Unarmed_Attack_Fire");
                            reply.Unarmed_Attack_Cold = (byte)read.GetUInt16("Unarmed_Attack_Cold");
                            reply.Unarmed_Attack_Lightning = (byte)read.GetUInt16("Unarmed_Attack_Lightning");
                            reply.Unarmed_Attack_Acid = (byte)read.GetUInt16("Unarmed_Attack_Acid");
                            reply.Unarmed_Attack_Poison = (byte)read.GetUInt16("Unarmed_Attack_Poison");
                            reply.Unknown1 = (byte)read.GetUInt16("Unknown1");
                            reply.Unknown2 = (byte)read.GetUInt16("Unknown2");
                            reply.Unarmed_Attack_Exp_Drain = (byte)read.GetUInt16("Unarmed_Attack_Exp_Drain");
                            reply.Unarmed_Attack_Exp_Steal = (byte)read.GetUInt16("Unarmed_Attack_Exp_Steal");
                            reply.Unarmed_Attack_Life_Steal = (byte)read.GetUInt16("Unarmed_Attack_Life_Steal");
                            reply.Unarmed_Attack_Rust = (byte)read.GetUInt16("Unarmed_Attack_Rust");
                            reply.Can_Hit_Etheral = (byte)read.GetUInt16("Can_Hit_Etheral");
                            reply.Unarmed_Attack_Stun = (byte)read.GetUInt16("Unarmed_Attack_Stun");
                            reply.Unknown3 = (byte)read.GetUInt16("Unknown3");
                            reply.Unknown4 = (byte)read.GetUInt16("Unknown4");
                            reply.Improved_Unarmed_Attack_Damage = (byte)read.GetUInt16("Improved_Unarmed_Attack_Damage");
                            reply.Can_See_Invis = (byte)read.GetUInt16("Can_See_Invis");
                            reply.Unknown5 = (byte)read.GetUInt16("Unknown5");
                            reply.Unknown6 = (byte)read.GetUInt16("Unknown6");
                            reply.Defenseless = (byte)read.GetUInt16("Defenseless");
                            reply.Unknown7 = (byte)read.GetUInt16("Unknown7");
                            reply.Unknown8 = (byte)read.GetUInt16("Unknown8");
                            reply.Fire_Immolated = (byte)read.GetUInt16("Fire_Immolated");
                            reply.Cold_Immolated = (byte)read.GetUInt16("Cold_Immolated");
                            reply.Acid_Immolated = (byte)read.GetUInt16("Acid_Immolated");
                            reply.Poison_Immolated = (byte)read.GetUInt16("Poison_Immolated");
                            reply.Lightning_Immolated = (byte)read.GetUInt16("Lightning_Immolated");
                            reply.Frozen = (byte)read.GetUInt16("Frozen");
                            reply.Held = (byte)read.GetUInt16("Held");
                            reply.Confused = (byte)read.GetUInt16("Confused");
                            reply.Unable_To_Flee_Combat = (byte)read.GetUInt16("Unable_To_Flee_Combat");
                            reply.Unknown9 = (byte)read.GetUInt16("Unknown9");
                            reply.Berzerked = (byte)read.GetUInt16("Berzerked");
                            reply.Stunned = (byte)read.GetUInt16("Stunned");
                            reply.Unknown10 = (byte)read.GetUInt16("Unknown10");
                            reply.Scared = (byte)read.GetUInt16("Scared");
                            reply.Quickened = (byte)read.GetUInt16("Quickened");
                            reply.Slowed = (byte)read.GetUInt16("Slowed");
                            reply.Empowered = (byte)read.GetUInt16("Empowered");
                            reply.Enfeebled = (byte)read.GetUInt16("Enfeebled");
                            reply.Shielded = (byte)read.GetUInt16("Shielded");
                            reply.Shielded2 = (byte)read.GetUInt16("Shielded2");
                            reply.Invulnerable = (byte)read.GetUInt16("Invulnerable");
                            reply.Regenerating = (byte)read.GetUInt16("Regenerating");
                            reply.Unknown11 = (byte)read.GetUInt16("Unknown11");
                            reply.Cursed = (byte)read.GetUInt16("Cursed");
                            reply.Rotting_In_Jail = (byte)read.GetUInt16("Rotting_In_Jail");
                            reply.Resistant_To_Magic = (byte)read.GetUInt16("Resistant_To_Magic");
                            reply.Immune_To_Magic = (byte)read.GetUInt16("Immune_To_Magic");
                            reply.Rust_Immolated = (byte)read.GetUInt16("Rust_Immolated");
                            reply.Unknown12 = (byte)read.GetUInt16("Unknown12");
                            reply.Unknown13 = (byte)read.GetUInt16("Unknown13");
                            reply.Resurrecting_25 = (byte)read.GetUInt16("Resurrecting_25");
                            reply.Resurrecting_50 = (byte)read.GetUInt16("Resurrecting_50");
                            reply.Resurrecting_100 = (byte)read.GetUInt16("Resurrecting_100");
                            reply.Extra_Attack = (byte)read.GetUInt16("Extra_Attack");
                            reply.Extra_Dodge = (byte)read.GetUInt16("Extra_Dodge");
                            reply.Spell_Memory_Protected = (byte)read.GetUInt16("Spell_Memory_Protected");
                            reply.Heightened_Dexterity = (byte)read.GetUInt16("Heightened_Dexterity");
                            reply.Lowered_Dexterity = (byte)read.GetUInt16("Lowered_Dexterity");
                            reply.Heightened_Intelligence = (byte)read.GetUInt16("Heightened_Intelligence");
                            reply.Lowered_Intelligence = (byte)read.GetUInt16("Lowered_Intelligence");
                            reply.Heightened_Endurance = (byte)read.GetUInt16("Heightened_Endurance");
                            reply.Lowered_Endurance = (byte)read.GetUInt16("Lowered_Endurance");
                            reply.Retention = (byte)read.GetUInt16("Retention");
                            reply.Vulnerable = (byte)read.GetUInt16("Vulnerable");
                            reply.Nourished = (byte)read.GetUInt16("Nourished");
                            reply.Changed_Gender = (byte)read.GetUInt16("Changed_Gender");
                            reply.Naked = (byte)read.GetUInt16("Naked");
                            reply.Ugly = (byte)read.GetUInt16("Ugly");
                            reply.Disguised = (byte)read.GetUInt16("Disguised");
                            reply.Encumberance_Bonus = (byte)read.GetUInt16("Encumberance_Bonus");
                            reply.Encumberance_Penalty = (byte)read.GetUInt16("Encumberance_Penalty");
                            reply.Unknown14 = (byte)read.GetUInt16("Unknown14");
                            reply.Shifting = (byte)read.GetUInt16("Shifting");
                            reply.Spell_Extention = (byte)read.GetUInt16("Spell_Extention");
                            reply.Poisoned = (byte)read.GetUInt16("Poisoned");
                            reply.Acid_Burned = (byte)read.GetUInt16("Acid_Burned");
                            reply.Unknown15 = (byte)read.GetUInt16("Unknown15");
                            reply.Unknown16 = (byte)read.GetUInt16("Unknown16");
                            reply.Unknown17 = (byte)read.GetUInt16("Unknown17");
                            reply.Unknown18 = (byte)read.GetUInt16("Unknown18");
                            reply.Unknown19 = (byte)read.GetUInt16("Unknown19");
                            reply.Unknown20 = (byte)read.GetUInt16("Unknown20");
                            reply.Protected_From_Death_Magic = (byte)read.GetUInt16("Protected_From_Death_Magic");
                            reply.Magical_Will_Increase = (byte)read.GetUInt16("Magical_Will_Increase");
                            reply.Unknown21 = (byte)read.GetUInt16("Unknown21");
                            reply.Unknown22 = (byte)read.GetUInt16("Unknown22");
                            reply.Unknown23 = (byte)read.GetUInt16("Unknown23");
                            reply.Unknown24 = (byte)read.GetUInt16("Unknown24");
                            reply.Unknown25 = (byte)read.GetUInt16("Unknown25");
                            reply.Unknown26 = (byte)read.GetUInt16("Unknown26");
                            reply.Unknown27 = (byte)read.GetUInt16("Unknown27");
                            reply.Unknown28 = (byte)read.GetUInt16("Unknown28");
                            reply.Unknown29 = (byte)read.GetUInt16("Unknown29");
                            reply.Unknown30 = (byte)read.GetUInt16("Unknown30");
                            reply.Unknown31 = (byte)read.GetUInt16("Unknown31");
                            reply.Unknown32 = (byte)read.GetUInt16("Unknown32");
                            reply.Unknown33 = (byte)read.GetUInt16("Unknown33");
                        }
                        return reply;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log it
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool SetAffect(uint charId, string affectName, bool giveOrTake = true)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("UPDATE Affets SET {0} = '{1}' WHERE CharID='{2}'",
                        affectName, giveOrTake ? 1:0, charId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool InsertNewAffects(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO Affects(CharID) VALUES({0})",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool DeleteAffects(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("DELETE FROM Affects WHERE CharID = '{0}'",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        Console.WriteLine("In Delete affects we got result of {0}", result);
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool HasAffects(uint charId)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Affect WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        return read.HasRows;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool PlayerHasAffect(uint charId, string affectName)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("SELECT * FROM Affects WHERE CharID = '{0}'",
                        charId)), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        int reply = 0;
                        while (read.Read())
                        {
                            reply = read.GetUInt16(affectName);
                        }
                        return reply == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        #endregion
        #region States
        public static CharacterStates LoadStates(uint charId)
        {
            CharacterStates reply = null;
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM States WHERE CharID='{0}'", charId), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (!read.HasRows) { return null; }
                        while (read.Read())
                        {
                            reply = new CharacterStates(charId);
                            reply.Attacks_Per_Round = (byte)read.GetUInt16("Attacks_Per_Round");
                            reply.Dodges_Per_Round = (byte)read.GetUInt16("Dodges_Per_Round");
                            reply.Blocks_Per_Round = (byte)read.GetUInt16("Blocks_Per_Round");
                            reply.Damage_Attack_Low = read.GetUInt16("Damage_Low");
                            reply.Damage_Attack_High = read.GetUInt16("Damage_High");
                            reply.Movement_Rate = (byte)read.GetUInt16("Movement_Rate");
                            reply.Encumberance_Low = read.GetUInt16("Encumberance_Low");
                            reply.Encumberance_High = read.GetUInt16("Encumberance_High");
                            reply.Kills_Good = read.GetInt32("Kills_Good");
                            reply.Kills_Evil = read.GetInt32("Kills_Evil");
                            reply.Mana_Drain = read.GetInt32("Mana_Drain");
                            reply.Armor_Pierce = read.GetInt32("Armor_Pierce");
                            reply.Evil_Mdm = read.GetInt32("Evil_Mdm");
                            reply.Good_Mdm = read.GetInt32("Good_Mdm");
                            reply.Spell_Resists = read.GetString("Spell_Resists");
                            reply.Cast_Resists = read.GetString("Cast_Resists");
                            reply.Account_Type = read.GetString("Account_Type");
                            reply.Billing_Date = read.GetUInt16("Billing_Date");
                            reply.Time_Credits = read.GetUInt16("Time_Credits");
                            reply.Coppers = read.GetInt32("Coppers");
                            reply.Referal_Code = read.GetString("Referal_Code");
                            reply.Melee_Dmg_Mod = read.GetUInt16("Melee_Damage_Mod");
                            reply.Spell_Dmg_Mod = read.GetUInt16("Spell_Damage_Mod");
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return reply;
        }
        public static bool InsertNewStatess(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO States(CharID) VALUES({0})",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool DeleteStates(uint charID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("DELETE FROM States WHERE CharID = '{0}'",
                        charID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool SetState(uint charId, string stateName, object value)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format("UPDATE States SET {0} = '{1}' WHERE CharID='{2}'",
                        stateName, value, charId), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        #endregion
        #region Magic Mail
        public static List<Mail> LoadMail(uint sqlID)
        {
            List<Mail> allMail = new List<Mail>();
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM mail WHERE CharID={0}", sqlID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (!read.HasRows) { return allMail; }
                        while (read.Read())
                        {
                            Mail m = new Mail();
                            m.Body = read.GetString("Body");
                            m.From = read.GetString("From");
                            m.MailID = read.GetInt32("MailID");
                            m.Subject = read.GetString("Subject");
                            m.TimeStamp = read.GetInt32("TimeStamp");
                            allMail.Add(m);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1} ", ex.StackTrace, ex.Message); }
            return allMail;
        }
        public static bool WriteMail(Mail mail, uint toID)
        {
            // Ok working, fix to find the player
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO mail VALUES ({0}, {1}, {2}, '{3}', '{4}', '{5}')",
                        toID, mail.MailID, mail.TimeStamp, mail.Subject, mail.From, mail.Body)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch { return false; }
        }
        public static bool DeleteMail(uint sqlCharID, int mailID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("DELETE FROM mail WHERE CharID = '{0}' AND MailID = '{1}'",
                        sqlCharID, mailID)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="acct"></param>
        /// <param name="mailID"></param>
        /// <returns>null if mail id not found.</returns>
        public static Mail ReadMail(Account acct, int mailID)
        {
            Mail reply = null;
            List<Mail> allMail = LoadMail(acct.CurrentCharacter.SqlCharId);
            foreach (Mail m in allMail)
            {
                if (mailID == m.MailID)
                {
                    reply = m;
                    break;
                }
            }
            return reply;
        }
        #endregion
        #region Items
       
        public static bool UpdateItem(uint sqlId, Item item)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandText = "UPDATE inventory SET SqlOwnerID = @sqlowner, Graphic = @graphic, Color = @color, Name = @name, Equiped = @equipped, LookDescription = @look, ItemType = @type, EquipmentSlot = @slot, ArmorFactor = @af, Durability = @dur, MinDamage = @min, MaxDamage = @max, Enchants = @enchants WHERE SqlID = @sqlid";
                        cmd.Parameters.AddWithValue("@sqlowner", item.SqlOwnerID);
                        cmd.Parameters.AddWithValue("@graphic", item.GraphicID);
                        cmd.Parameters.AddWithValue("@color", item.Color);
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@equipped", item.Equipped ? 1:0);
                        cmd.Parameters.AddWithValue("@look", item.LookAt);
                        cmd.Parameters.AddWithValue("@type", (int)item.Type);
                        cmd.Parameters.AddWithValue("@slot", (int)item.EquipableSlot);
                        cmd.Parameters.AddWithValue("@af", item.ArmorFactor);
                        cmd.Parameters.AddWithValue("@dur", item.Durability);
                        cmd.Parameters.AddWithValue("@min", item.MinimumDamage);
                        cmd.Parameters.AddWithValue("@max", item.MaximumDamage);
                        cmd.Parameters.AddWithValue("@enchants", MySqlDbType.Blob).Value = item.Enchantments.ToArray();
                        cmd.Parameters.AddWithValue("@sqlid", sqlId);
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                    /*
                    using (MySqlCommand cmd = new MySqlCommand(string.Format(
                        "UPDATE inventory SET SqlOwnerID = {0}, Graphic = {1}, Color = {2}, Name = '{3}', Equiped = {4}, LookDescription = '{5}', ItemType = {6}, EquipmentSlot = {7}, ArmorFactor = {8}, Durability = {9}, MinDamage = {10}, MaxDamage = {11} WHERE SqlID = {12}",
                        item.SqlOwnerID, item.GraphicID, item.Color, item.ItemName, item.Equipped ? 1:0, item.LookAt, (int)item.Type, (int)item.EquipableSlot, item.ArmorFactor, item.Durability, item.MinimumDamage, item.MaximumDamage, item.SqlID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                     */
                }
            }
            catch (Exception ex) { Console.WriteLine("Error Updating Item {0} : {1}",ex.Message, ex.StackTrace); return false; }
        }
        public static bool UpdateItem(Item item)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandText = "UPDATE inventory SET SqlOwnerID = @sqlowner, Graphic = @graphic, Color = @color, Name = @name, Equiped = @equipped, LookDescription = @look, ItemType = @type, EquipmentSlot = @slot, ArmorFactor = @af, Durability = @dur, MinDamage = @min, MaxDamage = @max, Enchants = @enchants WHERE SqlID = @sqlid";
                        cmd.Parameters.AddWithValue("@sqlowner", item.SqlOwnerID);
                        cmd.Parameters.AddWithValue("@graphic", item.GraphicID);
                        cmd.Parameters.AddWithValue("@color", item.Color);
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@equipped", item.Equipped ? 1 : 0);
                        cmd.Parameters.AddWithValue("@look", item.LookAt);
                        cmd.Parameters.AddWithValue("@type", (int)item.Type);
                        cmd.Parameters.AddWithValue("@slot", (int)item.EquipableSlot);
                        cmd.Parameters.AddWithValue("@af", item.ArmorFactor);
                        cmd.Parameters.AddWithValue("@dur", item.Durability);
                        cmd.Parameters.AddWithValue("@min", item.MinimumDamage);
                        cmd.Parameters.AddWithValue("@max", item.MaximumDamage);
                        cmd.Parameters.AddWithValue("@enchants", MySqlDbType.Blob).Value = item.Enchantments.ToArray();
                        cmd.Parameters.AddWithValue("@sqlid", item.SqlID);
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                    /*
                    using (MySqlCommand cmd = new MySqlCommand(string.Format(
                        "UPDATE inventory SET SqlOwnerID = {0}, Graphic = {1}, Color = {2}, Name = '{3}', Equiped = {4}, LookDescription = '{5}', ItemType = {6}, EquipmentSlot = {7}, ArmorFactor = {8}, Durability = {9}, MinDamage = {10}, MaxDamage = {11} WHERE SqlID = {12}",
                        item.SqlOwnerID, item.GraphicID, item.Color, item.ItemName, item.Equipped ? 1:0, item.LookAt, (int)item.Type, (int)item.EquipableSlot, item.ArmorFactor, item.Durability, item.MinimumDamage, item.MaximumDamage, item.SqlID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                     */
                }
            }
            catch (Exception ex) { Console.WriteLine("Error Updating Item {0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public static bool DeleteItem(int sqlItemID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM inventory WHERE SqlID={0}",
                        sqlItemID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool SaveItem(uint sqlOwnerID, BaseGameItem item)
        {
            // Ok working, fix to find the player
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand("ALTER TABLE inventory AUTO_INCREMENT = 0;"+
                        "INSERT INTO inventory VALUES (0, @sqlowner, @graphic, @color, @name, @equipped, @look, @type, @slot, @af, @dur, @min, @max, @enchants)", c))
                    {
                        cmd.Parameters.AddWithValue("@sqlowner", item.SqlOwnerID);
                        cmd.Parameters.AddWithValue("@graphic", item.GraphicID);
                        cmd.Parameters.AddWithValue("@color", item.Color);
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@equipped", item.Equipped ? 1:0);
                        cmd.Parameters.AddWithValue("@look", item.LookAt);
                        cmd.Parameters.AddWithValue("@type", (int)item.Type);
                        cmd.Parameters.AddWithValue("@slot", (int)item.EquipableSlot);
                        cmd.Parameters.AddWithValue("@af", item.ArmorFactor);
                        cmd.Parameters.AddWithValue("@dur", item.Durability);
                        cmd.Parameters.AddWithValue("@min", item.MinimumDamage);
                        cmd.Parameters.AddWithValue("@max", item.MaximumDamage);
                        cmd.Parameters.AddWithValue("@enchants", item.Enchantments.ToArray());
                        int result = cmd.ExecuteNonQuery();
                         item.SqlID = (int)cmd.LastInsertedId;
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace);  return false; }
        }
        public static bool EquipItem(int sqlID, bool unequip = false)
        {
            if (!IsInitialized) { return false; }
            try
            {
                string un = unequip ? "0" : "1";
                Console.WriteLine("Equip {0}", un);
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE inventory SET Equiped = {0} WHERE SqlID = {1}",
                        unequip ? "0":"1" , sqlID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static List<BaseGameItem> LoadItems(uint sqlOwnerID)
        {
            List<BaseGameItem> allItems = new List<BaseGameItem>();
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM inventory WHERE SqlOwnerID= {0}", sqlOwnerID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        //if (!read.HasRows) { allItems.ToArray(); }
                        while (read.Read())
                        {
                            Item i = new Item();
                            i.SqlID = read.GetInt32("SqlID");
                            i.SqlOwnerID = sqlOwnerID;
                           // i.SqlOwnerID = read.GetInt32("SqlOwnerID");
                            i.GraphicID = (ushort)read.GetInt16("Graphic");
                            i.Color = (ushort)read.GetInt16("Color");
                            i.Name = read.GetString("Name");
                            i.Equipped = Convert.ToBoolean(read.GetInt32("Equiped"));
                           // i.CurrentGameID = (uint)read.GetUInt32("CurrentID");
                            i.LookAt = read.GetString("LookDescription");
                            i.Type = ItemTypeConvertor.FromInt(read.GetInt32("ItemType"));
                            i.EquipableSlot = EquipmentSlotConvertor.ToEquipmentSlot(read.GetInt32("EquipmentSlot"));
                            i.ArmorFactor = read.GetInt16("ArmorFactor");
                            i.Durability = read.GetInt16("Durability");
                            i.MinimumDamage = read.GetInt16("MinDamage");
                            i.MaximumDamage = read.GetInt16("MaxDamage");
                            byte[] chantBuffer = (byte[])read["Enchants"];
                            foreach (byte b in chantBuffer) i.Enchantments.Add(b);
                            allItems.Add(i);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Load Items "+ex.Message); }
            return allItems;
        }
        public static Item GetItem(int sqlID)
        {
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM inventory WHERE SqlID = {0}",
                        sqlID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        //if (!read.HasRows) { allItems.ToArray(); }
                        if (read.Read())
                        {
                            Item i = new Item();
                            i.SqlID = read.GetInt32("SqlID");
                            i.SqlOwnerID = read.GetUInt32("SqlOwnerID");
                            i.GraphicID = (ushort)read.GetInt16("Graphic");
                            i.Color = (ushort)read.GetInt16("Color");
                            i.Name = read.GetString("Name");
                            i.Equipped = Convert.ToBoolean(read.GetInt32("Equiped").ToString());
                          //  i.CurrentGameID = (uint)read.GetUInt32("CurrentID");
                            i.LookAt = read.GetString("LookDescription");
                            i.Type = ItemTypeConvertor.FromInt(read.GetInt32("ItemType"));
                            i.EquipableSlot = EquipmentSlotConvertor.ToEquipmentSlot(read.GetInt32("EquipmentSlot"));
                            i.ArmorFactor = read.GetInt16("ArmorFactor");
                            i.Durability = read.GetInt16("Durability");
                            i.MinimumDamage = read.GetInt16("MinDamage");
                            i.MaximumDamage = read.GetInt16("MaxDamage");
                            byte[] chantBuffer = (byte[])read["Enchants"];
                            foreach (byte b in chantBuffer) i.Enchantments.Add(b);
                            return i;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Load Items " + ex.Message); }
            return null;
        }
        #endregion
        #region Doors
        public static bool SaveDoor(uint sqlOwnerID, BaseGameItem item)
        {
            // Ok working, fix to find the player
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("ALTER TABLE inventory AUTO_INCREMENT = 0;INSERT INTO inventory VALUES (0, {0}, {1}, {2}, '{3}', {4}, '{5}', {6})",
                        sqlOwnerID, item.GraphicID, item.Color, item.Name, item.Equipped ? 1 : 0, item.LookAt, (int)item.Type)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        item.SqlID = (int)cmd.LastInsertedId;
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        #endregion
        #region Debugging Information
        public static bool DeleteDebugInfo(int recordID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM debug WHERE RowID={0}",
                        recordID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool SaveDebugInfo(DebugInfo info)
        {
            // Ok working, fix to find the player
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO debug VALUES (0, {0}, {1}, '{2}', '{3}')",
                        info.AccountID, info.CharID, info.DateTime, info.Error)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public static DebugInfo GetDebugInfo(int recordID)
        {
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM debug WHERE RowID = {0}",
                        recordID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            DebugInfo d = new DebugInfo();
                            d.RecordID = read.GetInt32("RowID");
                            d.AccountID = read.GetUInt32("AccountID");
                            d.CharID = read.GetUInt32("CharID");
                            d.DateTime = read.GetString("DateTime");
                            d.Error = read.GetString("Error");
                            return d;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Load Items " + ex.Message); }
            return null;
        }
        #endregion
        #region What's New
        public static bool DeleteWhatsNewRecord(int recordID)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM whatsnew WHERE ID={0}",
                        recordID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public static bool SaveWhatsNew(WhatsNewMessage wn)
        {
            // Ok working, fix to find the player
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd =
                    new MySqlCommand(string.Format(string.Format("INSERT INTO whatsnew VALUES (0, {0}, '{1}', '{2}', '{3}')",
                       wn.Color, wn.Message, wn.TimeStamp, wn.Author)), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public static WhatsNewMessage GetWhatsNew(int recordID)
        {
            if (!IsInitialized) { return null; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM whatsnew WHERE ID = {0}",
                        recordID), c))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            WhatsNewMessage w = new WhatsNewMessage();
                            w.ID = read.GetInt32("ID");
                            w.Color = read.GetInt32("Color");
                            w.Message = read.GetString("Message");
                            w.TimeStamp = read.GetString("TimeStamp");
                            w.Author = read.GetString("Author");
                            return w;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Loading Whats new by record ID {0} : {1}. ", ex.Message, ex.StackTrace); }
            return null;
        }
        public static List<WhatsNewMessage> GetWhatsNew(string search)
        {
            List<WhatsNewMessage> reply = new List<WhatsNewMessage>();
            if (!IsInitialized) { return reply; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM whatsnew", c))
                    {
                        search = search.ToLower();
                        MySqlDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            WhatsNewMessage w = new WhatsNewMessage();
                            w.ID = read.GetInt32("ID");
                            w.Color = read.GetInt32("Color");
                            w.Message = read.GetString("Message");
                            w.TimeStamp = read.GetString("TimeStamp");
                            w.Author = read.GetString("Author");
                            if (w.Author.ToLower().Contains(search) || w.TimeStamp.ToLower().Contains(search)
                                || search == "*") 
                                reply.Add(w);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Load Whats New {0} : {1} ", ex.Message, ex.StackTrace); }
            return reply;
        }
        public static bool UpdateWhatsNew(WhatsNewMessage wn)
        {
            if (!IsInitialized) { return false; }
            try
            {
                using (MySqlConnection c = new MySqlConnection(xml.GetMySqlConnection))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE whatsnew set Color = {0}, Message = '{1}', TimeStamp = '{2}', Author = '{3}' WHERE ID = {4}",
                        wn.Color, wn.Message, wn.TimeStamp, wn.Author, wn.ID), c))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result == 1;

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Updating Whats new by record ID {0} : {1}. ", ex.Message, ex.StackTrace); }
            return false;
        }
        #endregion
    }
}
