using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp;
using RealmOffline.Packets;
using RealmOffline.Managers;
using RealmOffline.Core;
using System.IO;
using System.Reflection;
using RealmOffline.Core.Mobiles;
using RealmOffline.Base;
using System.Diagnostics;
using RealmOffline.Core.Items;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Accounts
{
    public class Character : Entity
    {
        public override ushort Color { get; set; }
        public override ushort GraphicID { get; set; }
        public uint SqlCharId { get; set; }
        public uint AccountOwnerId { get; set; }
        public override uint GameID { get; set; }
        public uint InventoryId = 0;
        public List<uint> IDsInUse{ get; set; }
        public int CurrentXP { get; set; }
        public long Gold { get; set; }
        public long Mana { get; set; }
        public ushort Level { get; set; }
        public int Experience { get; set; }
        public override string Name { get; set; }
        public string Title { get; set; }
        public byte Class { get; set; }
        public byte Race { get; set; }
        public byte Gender { get; set; }
        public byte Girth { get; set; }
        public byte Height { get; set; }
        public byte Alignment { get; set; }
        public byte RaceHead { get; set; }
        public byte HeadPart { get; set; }
        public byte ChinPart { get; set; }
        public byte HairPart { get; set; }
        public byte EyeBrowPart { get; set; }
        public byte EyePart { get; set; }
        public byte NosePart { get; set; }
        public byte EarPart { get; set; }
        public byte MouthPart { get; set; }
        public byte FacialHairPart { get; set; }
        public byte SkinColor { get; set; }
        public byte HairColor { get; set; }
        public byte EyeColor { get; set; }
        public byte Invis { get; set; }
        public byte PvpSwitch { get; set; }
        /// <summary>
        /// Stat Data
        /// </summary>
        public byte Strength { get; set; }
        public byte Dexterity { get; set; }
        public byte Intelligence { get; set; }
        public byte Constitution { get; set; }
        /// <summary>
        /// Parts Data
        /// </summary>

        public string Biography = "";

        public bool CharDataAdded { get; set; }
        public bool PartDataAdded { get; set; }
        public bool DescriptionAdded { get; set; }
        public bool SkillsAdded { get; set; }
        public bool HasCharID { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int CurrentHP { get; set; }
        public int TotalHP { get; set; }
        public ushort BuildPoints { get; set; }
        //public uint CurrentRoom { get; set; }

        public RoomLocation Location { get; set; }

        public MagicMail GameMail { get; set; }

        public CombatCloud Cloud { get; set; }
        public bool IsMob { get; private set; }
        public short MobGraphic { get; private set; }
        public List<BaseGameItem> Inventory { get; private set; }

        public bool SwitchCharacterToMob(short mobGraphic)
        {
            bool valid = Mob.IsValidID(mobGraphic);
            bool setId = false;
            if (valid)
            {
                this.IsMob = MySqlManager.TryUpdateCharValue("IsMob", 1, this.SqlCharId);
                if (this.IsMob)
                {
                    this.MobGraphic = mobGraphic;
                    setId = MySqlManager.TryUpdateCharValue("MobGraphic", (ulong)this.MobGraphic, this.SqlCharId);
                }
            }
            return this.IsMob && setId;
        }
        public void ResetCharacterGraphic()
        {
            this.IsMob = MySqlManager.TryUpdateCharValue("IsMob", 0, this.SqlCharId);
            this.MobGraphic = 0;
            MySqlManager.TryUpdateCharValue("MobGraphic", (ulong)this.MobGraphic, this.SqlCharId);
        }
        public bool CreateComplete
        {
            get
            {
                return this.CharDataAdded && this.PartDataAdded && this.DescriptionAdded &&
                    this.SkillsAdded && this.HasCharID;
            }
        }
        /*
         * Ok break this down into 3 parts, so it will say if its ready or not
         */
        public Character()
        {
            this.IDsInUse = new List<uint>();
            Inventory = new List<BaseGameItem>();
            this.CharDataAdded = false;
            this.PartDataAdded = false;
            this.DescriptionAdded = false;
            this.SkillsAdded = false;
            this.HasCharID = false;
            // set up our combat cloud
            Account a = ServerGlobals.GetAccountFromCharacter(this);
            if (a != null)
            {
                this.Cloud = new CombatCloud();
                this.Cloud.CloudOwner = a;
                this.Cloud.GraphicID = 0x01;
            }
        }
        public bool AddInventoryItem(BaseGameItem item)
        {
            if (!this.Inventory.Contains(item))
            {
                this.Inventory.Add(item);
                return true;
            }
            return false;
        }
        public bool RemoveInventoryItem(BaseGameItem item)
        {
            if (this.Inventory.Contains(item))
            {
                this.Inventory.Remove(item);
                return true;
            }
            return false;
        }
        public BaseGameItem GetInventoryItem(uint gameID)
        {
            BaseGameItem reply = null;
            for (int i = 0; i < this.Inventory.Count; i++)
            {
                if (this.Inventory[i].GameID == gameID)
                {
                    reply = this.Inventory[i]; break;
                }
            }
            return reply;
        }
        public void AssignCharID(uint charId, bool saveToSql = true)
        {
            this.GameID = charId;
            this.IDsInUse.Add(charId);
            // try to update sql
           // bool charid = false;
            //if(saveToSql)
             //   charid = MySqlManager.TryUpdateCharValue("CurrentID", charId, this.SqlCharId);
           // if (!charid) Console.WriteLine("Error writing CharID {0} for {1}", charId, Name);  
            this.HasCharID = true;
        }
        // Correct
        #region AddCharData
        public void AddCharData(string pName, string pTitle, byte pClass, byte pRace, byte pGender,
            byte pPvpSwitch, byte pStrength, byte pDexterity, byte pIntelligence, byte pEndurance,
            byte pAlignment, byte pGirth, byte pHeight)
        {
            this.Name = pName;
            this.Title = pTitle;
            this.Class = pClass;
            this.Race = pRace; 
            this.Gender = pGender;
            this.PvpSwitch = pPvpSwitch;
            this.Strength = pStrength;
            this.Dexterity = pDexterity;
            this.Intelligence = pIntelligence;
            this.Constitution = pEndurance;
            this.Alignment = pAlignment;
            this.Girth = pGirth;
            this.Height = pHeight;
            this.CharDataAdded = true;
        }
        public void AddPartData(byte pRaceHead, byte pGenderHead, byte pHeadPart, byte pHairPart, byte pBrowPart,
            byte pEyePart, byte pNosePart, byte pEarsPart, byte  pMouthPart, byte pBeardPart,
            byte pSkinColor, byte pHairColor, byte pEyeColor)
        {
            this.RaceHead = pRaceHead;
            bool race = MySqlManager.TryUpdateCharValue("RaceHead", pRaceHead, this.SqlCharId);
            this.Gender = pGenderHead;
            bool gender = MySqlManager.TryUpdateCharValue("Gender", pGenderHead, this.SqlCharId);
            this.HeadPart = pHeadPart;
            bool head = MySqlManager.TryUpdateCharValue("HeadPart", pHeadPart, this.SqlCharId);
            this.HairPart = pHairPart;
            bool hair = MySqlManager.TryUpdateCharValue("HairPart", pHairPart, this.SqlCharId);
            this.EyeBrowPart = pBrowPart;
            bool ebp = MySqlManager.TryUpdateCharValue("EyeBrowPart", pBrowPart, this.SqlCharId);
            this.EyePart = pEyePart;
            bool eye = MySqlManager.TryUpdateCharValue("EyePart", pEyePart, this.SqlCharId);
            this.NosePart = pNosePart;
            bool nose = MySqlManager.TryUpdateCharValue("NosePart", pNosePart, this.SqlCharId);
            this.EarPart = pEarsPart;
            bool ear = MySqlManager.TryUpdateCharValue("EarPart", pEarsPart, this.SqlCharId);
            this.MouthPart = pMouthPart;
            bool mouth = MySqlManager.TryUpdateCharValue("MouthPart", pMouthPart, this.SqlCharId);
            this.FacialHairPart = pBeardPart;
            bool fhp = MySqlManager.TryUpdateCharValue("FacialHairPart", pBeardPart, this.SqlCharId);
            this.SkinColor = pSkinColor;
            bool scolor = MySqlManager.TryUpdateCharValue("SkinColor", pSkinColor, this.SqlCharId);
            this.HairColor = pHairColor;
            bool hc = MySqlManager.TryUpdateCharValue("HairColor", pHairColor, this.SqlCharId);
            this.EyeColor = pEyeColor;
            bool ec = MySqlManager.TryUpdateCharValue("EyeColor", pEyeColor, this.SqlCharId);
            this.PartDataAdded = true;
            bool up = race && gender && head && hair && ebp && eye && nose
                && ear && mouth && fhp && scolor && hc && ec;
            Console.WriteLine("All Updated ? {0}", up);
        }
        public void AddDescription(byte[] description)
        {
            this.Biography = Encoding.ASCII.GetString(description);
            bool up = MySqlManager.TryUpdateCharValue("Biography", this.Biography, this.SqlCharId);
            Console.WriteLine("Updated Bio {0}", up);
            this.DescriptionAdded = true;
        }
        #endregion
        /*
         * We need a way to load stats from the mysql server
         * and a way to generate new char stats by class
         */

        public void AddBaseSkillsByClass(int pClass)
        {
            this.SkillsAdded = true;
        }
        public void LoadStatsFromMysql()
        {
            this.SkillsAdded = true;
        }
        // Did i fuck this up ?
        #region Add to Room (For loading players already in room when a new person enters)
        public byte[] AddToRoom()
        {
            ushort totalInv = 0;
            byte[] equip = GetEquipedItems(out totalInv);
            //Console.WriteLine("The char we want to add to room in code has {0} items", totalInv);

            PacketWriter w = new PacketWriter();
            if (IsMob)
            {
                w.WriteByte(0x01);
                w.WriteShort(this.MobGraphic);
            }
            else
            {
                // Replaces the 0x01, 0x07, 0x00
                w.WriteUShort(ClassType.Get(this.Class));
                w.WriteByte(0);
            }
            
            w.WriteUInt32(this.GameID);
            // Replaces 0x00, 0x53, setting this to 15 makes you invis at login
            w.WriteByte(0x00);
            w.WriteByte(0x53);
            w.WriteByte(0x54);
            // spells
            //w.WriteByte(0x00);
            // Add another 0 here ?
            w.WriteByte(0xFF); // Ends char setup

            w.WriteByte(0x00);
            w.WriteByte(0x0C);
            w.WriteByte(0x08);
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            if (IsMob) w.WriteByte(0x01);
            else w.WriteByte(this.Class);
            w.WriteByte(this.Race);
            w.WriteByte(this.Gender);
            w.WriteString(this.Name);
            w.WriteByte(this.PvpSwitch);
            w.WriteInt32(this.CurrentHP); // cur hp
            w.WriteInt32(this.TotalHP); // max hp

            if (this.Location.CurrentRoom.RoomID < 65535)
            {
                // 1 bytes
                w.WriteByte(0x01);
                w.WriteUShort((ushort)this.Location.CurrentRoom.RoomID);
            }
            else
            {
                // 2 byte
                w.WriteByte(0x02);
                w.WriteUInt32(this.Location.CurrentRoom.RoomID);
            }
            w.WriteUShort(this.Location.X);
            w.WriteUShort(this.Location.Y);
            w.WriteUShort(this.Location.Facing);
            if (IsMob)
                w.WriteBytes(new byte[2]);
            else
            {
                w.WriteUShort((ushort)(totalInv + 1));//(0x01); // think this is how many inv items
                // Build Inventory
                w.WriteByte(0x01);
                w.WriteUShort(0x04);
                w.WriteUInt32(this.InventoryId);
                w.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0xFF });
                w.WriteBytes(new byte[3]);

                w.WriteByte(this.RaceHead);
                w.WriteByte(this.Gender);
                w.WriteByte(this.ChinPart);
                w.WriteByte(this.HairPart);
                w.WriteByte(this.EyeBrowPart);
                w.WriteByte(this.EyePart);
                w.WriteByte(this.NosePart);
                w.WriteByte(this.EarPart);
                w.WriteByte(this.MouthPart);
                w.WriteByte(this.FacialHairPart);
                w.WriteByte(this.SkinColor);
                w.WriteByte(this.HairColor);
                w.WriteByte(this.EyeColor);
                w.WriteBytes(new byte[6]);
                w.WriteBytes(equip);
            }
            w.WriteBytes(new byte[5]);
            byte[] reply = w.GetRawPacket();
            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "pureroomchar.txt");
              File.WriteAllText(fileLocation, BitConverter.ToString(reply));
              return reply;
        }
        #endregion

        // This works, but it isnt right
        #region GetApperance (Adds to exisiting room, not on packet 33)
        public byte[] GetAppearance(uint room)
        {
            PacketWriter header = new PacketWriter();
            header.WriteByte(0x40);

            PacketWriter c = new PacketWriter();
            c.WriteBytes(new byte[] { 0x02, 0x70, 0x04, 0x00 });
            // now the char
            if (IsMob)
            {
                c.WriteByte(0x01);
                c.WriteShort(this.MobGraphic);
                // unequip all items, and do not alow them to be equipped
            }
            else
            {
                // Replaces the 0x01, 0x07, 0x00
                c.WriteUShort(ClassType.Get(this.Class));
                c.WriteByte(0);
            }

            c.WriteUInt32(this.GameID);

            c.WriteBytes(new byte[] { 0x00, 0x53, 0x54, 0x00, 0xFF, 0x00, 0x0C, 0x08 });
            c.WriteByte(this.Girth);
            c.WriteByte(this.Height);
            if (IsMob) c.WriteByte(0x01);
            else c.WriteByte(this.Class);
            c.WriteByte(this.Race);
            c.WriteByte(this.Gender); //Console.WriteLine("Gender is {0} Genderhead is {1}", this.Gender, this.HeadPart);
            c.WriteString(this.Name);
            c.WriteByte(this.PvpSwitch);
            c.WriteInt32(this.CurrentHP);//this.SqlCharId);
            c.WriteInt32(this.TotalHP);//this.SqlCharId);

            if (room < 65535)
            {
                // 3 bytes
                c.WriteByte(0x01);
                c.WriteUShort((ushort)room);
            }
            else
            {
                //5 bytes
                c.WriteByte(0x02);
                c.WriteUInt32(room);
            }
            c.WriteUShort(this.Location.X);
            c.WriteUShort(this.Location.Y);
            // facing is fucked up atm
            c.WriteUShort(this.Location.Facing);//this.Location.Facing);
            if (IsMob)
                c.WriteBytes(new byte[2]);
            else
            {
                // Ok really need to sit down and fix inventory
                ushort totalInv = 0;
                byte[] equip = GetEquipedItems(out totalInv);
                c.WriteUShort((ushort)(totalInv + 1)); // just add the total here
                // Now we build the inventory container
                c.WriteByte(0x01);
                c.WriteUShort(0x04);
                c.WriteUInt32(this.InventoryId);
                /* This is not fully understood
                 * Your inventory is alot like a char and or a item
                 * it may be able to hold buffs.
                 */
                c.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0xFF });
                c.WriteBytes(new byte[3]);
                c.WriteByte(this.Race);
                c.WriteByte(this.Gender);
                c.WriteByte(this.ChinPart);
                c.WriteByte(this.HairPart);
                c.WriteByte(this.EyeBrowPart);
                c.WriteByte(this.EyePart);
                c.WriteByte(this.NosePart);
                c.WriteByte(this.EarPart);
                c.WriteByte(this.MouthPart);
                c.WriteByte(this.FacialHairPart);
                c.WriteByte(this.SkinColor);
                c.WriteByte(this.HairColor);
                c.WriteByte(this.EyeColor);

                c.WriteBytes(new byte[6]);

                c.WriteBytes(equip);
            }
            // no inventory 
            c.WriteUShort(0);

            byte[] player = c.ToArray(false, true);// no crc and appends ushort for len not uint


            header.WriteBytes(player);
            return header.GetRawPacket();
        }
        #endregion

        #region Generate Char Packet (For Packet 0x12 (18))
        public byte[] GenerateCharacterPacket()
        {
            // IsMob = true;
            PacketWriter w = new PacketWriter();
            // Replaces the 0x01, 0x07, 0x00
            if (IsMob)
            {
                w.WriteByte(0x01);
                w.WriteShort(this.MobGraphic);
                // unequip all items, and do not alow them to be equipped
            }
            else
            {
                // Replaces the 0x01, 0x07, 0x00
                w.WriteUShort(ClassType.Get(this.Class));
                w.WriteByte(0x00);
            }
            //w.WriteUShort(ClassType.Get(this.Class));
            // w.WriteByte(0);
            if (!this.HasCharID) this.AssignCharID(ServerGlobals.GetNextAvailableID());

            w.WriteUInt32(this.GameID);
            w.WriteByte(0x00);
            w.WriteByte(0x53);
            w.WriteShort(0x54);
            w.WriteByte(0xFF); // Ends char setup
            // All about this used to be 0x01, 0x07, 0x00, 0x35, 0x5C, 0x04, 0x00, 0x00, 0x53, 0x54, 0x00, 0xFF
            // Now the old 0x00, 0x0C, 0x08 saying char data starts
            w.WriteByte(0x00);
            w.WriteShort(2060);
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            if (IsMob) w.WriteByte(0x01);
            else w.WriteByte(this.Class);
            w.WriteByte(this.Race);
            w.WriteByte(this.Gender);
            w.WriteString(this.Name);
            w.WriteByte(this.PvpSwitch);
            w.WriteInt32(this.CurrentHP); // curent hp
            w.WriteInt32(this.TotalHP); // max hp
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            if (IsMob)
                w.WriteBytes(new byte[2]);
            else
            {
                this.Inventory = MySqlManager.LoadItems(this.SqlCharId);
                // First time we load items, set the id's
                // Console.WriteLine("Items for {0} {1} Loaded.", this.Name, inventory.Length);
                //  Stopwatch stop = new Stopwatch();
                //stop.Start();

                for (int i = 0; i < this.Inventory.Count; i++)
                {
                    this.Inventory[i].GameID = ServerGlobals.GetNextAvailableID();
                    this.IDsInUse.Add(this.Inventory[i].GameID);
                    //  bool updated = MySqlManager.UpdateItemID(inventory[i].SqlID, inventory[i].CurrentGameID);
                    // Console.Write("\r{0}  ", i);
                    //Console.WriteLine("Item {0} loaded {1}", i.ID, updated);
                }
                // stop.Stop();
                // Console.WriteLine("{0} items loaded in {1} Minute(s) and {2} second(s).", inventory.Length, stop.Elapsed.Minutes, stop.Elapsed.Seconds);
                //stop.Reset();
                short itotal = (short)(this.Inventory.Count + 1);
                //Console.WriteLine("{0} inventory items for charid {1}", itotal, this.CharId);

                w.WriteShort(itotal); // how many inventory items we have.

                // Create the inventory Container to hold all other inventory, this is counted as a item
                // should be 33 bytes


                w.WriteByte(0x01);
                w.WriteShort(0x04);
                this.InventoryId = ServerGlobals.GetNextAvailableID();
                w.WriteUInt32(this.InventoryId);
                w.WriteBytes(new byte[3]);
                w.WriteByte(0xFF); // end

                w.WriteByte(0x00);
                w.WriteByte(0x00);
                w.WriteByte(0x00);

                //w.WriteBytes(new byte[3]);
                // begin Part data


                w.WriteByte(this.RaceHead);
                w.WriteByte(this.Gender);
                w.WriteByte(this.ChinPart);
                w.WriteByte(this.HairPart);
                w.WriteByte(this.EyeBrowPart);
                w.WriteByte(this.EyePart);
                w.WriteByte(this.NosePart);
                w.WriteByte(this.EarPart);
                w.WriteByte(this.MouthPart);
                w.WriteByte(this.FacialHairPart);
                w.WriteByte(this.SkinColor);
                w.WriteByte(this.HairColor);
                w.WriteByte(this.EyeColor);

                w.WriteByte(0x00);
                w.WriteByte(0x00);
                w.WriteByte(0x00);
                w.WriteByte(0x00);
                w.WriteByte(0x00);
                w.WriteByte(0x00);
                //w.WriteBytes(new byte[4]); // Not sure if these have values, i never see them
                // Could be, item, then 1 byte spacer, 

                for (int i = 0; i < this.Inventory.Count; i++)
                {
                    this.Inventory[i].IsInventoryItem = true;
                    ItemType type = BaseItem.GetItemType(this.Inventory[i].GraphicID);
                   // if (this.Inventory[i] is Container)
                   // {
                     //   Console.WriteLine("Container {0} found, type says {1}.", 
                     //       this.Inventory[i].GraphicID, type);
                  //  }
                   // if (this.Inventory[i] is Container)
                   // {
                     //   Console.WriteLine("Entity is a container");
                  //  }
                    if (type == ItemType.Container)
                    {
                        Container c = Container.CastFromBaseGameItem(this.Inventory[i]);
                        if (c != null)
                            Console.WriteLine("Container created.");
                        w.WriteBytes(c.Serialize());

                    }
                    else
                    w.WriteBytes(this.Inventory[i].Serialize());
                }
            }
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            //w.WriteBytes(new byte[5]); // when inventory ends we got 5 bytes
            return w.ToArray(false);
        }
        #endregion
        #region GetEquiped Items
        public byte[] GetEquipedItems(out ushort total)
        {
            total = 0;
            //Item[] allitems = MySqlManager.LoadItems(this.SqlCharId);
            PacketWriter w = new PacketWriter();
            for (int i = 0; i < this.Inventory.Count; i++)
            {
                if (this.Inventory[i].Equipped == true)
                {
                    total++;
                    w.WriteBytes(this.Inventory[i].Serialize());
                }
            }
            return w.GetRawPacket();
        }
        #endregion
        #region CreateNewChar 48
        // Fixed, dont screw with anything but inventory
        public byte[] CreateNewChar48(uint accountID)
        {
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(accountID);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x30);
            w.WriteUInt32(0x00);
            // New
            w.WriteUShort(ClassType.Get(this.Class));
            w.WriteByte(0x00);
            if (!this.HasCharID) this.AssignCharID(ServerGlobals.GetNextAvailableID());

            w.WriteUInt32(this.GameID);

            this.InventoryId= ServerGlobals.GetNextAvailableID();
            this.IDsInUse.Add(this.InventoryId);
            // Replaces 0x00, 0x53, setting this to 15 makes you invis at login
            w.WriteByte(0x00);
            w.WriteByte(0x53);
            w.WriteByte(0x54);
            w.WriteByte(0xFF); // Ends char setup
            // All about this used to be 0x01, 0x07, 0x00, 0x35, 0x5C, 0x04, 0x00, 0x00, 0x53, 0x54, 0x00, 0xFF
            // Now the old 0x00, 0x0C, 0x08 saying char data starts
            w.WriteByte(0x00);
            w.WriteShort(2060);
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            w.WriteByte(this.Class);
            w.WriteByte(0x00);// (this.Race);
            w.WriteByte(this.Gender);
            w.WriteString(this.Name);
            w.WriteByte(this.PvpSwitch);
            w.WriteInt32(this.CurrentHP); // current hp
            w.WriteInt32(this.TotalHP); // max hp
            w.WriteShort(0);
            this.Inventory = GenerateNewInventory();

            short total = (short)(this.Inventory.Count +1); // can be 65534 total items
            w.WriteShort(total);
            // Now inventory
            for (int i = 0; i < this.Inventory.Count; i++)
            {
                w.WriteBytes(this.Inventory[i].Serialize());
            }
            // Now we build master inventory
            // Create the inventory Container to hold all other inventory, this is counted as a item
            w.WriteByte(0x01);
            w.WriteShort(0x04);
            w.WriteUInt32(this.InventoryId);
            w.WriteBytes(new byte[3]);
            w.WriteByte(0xFF); // end
            w.WriteBytes(new byte[3]);
            w.WriteByte(0x01);
            w.WriteByte(0x00);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x00);
            w.WriteShort(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x2E);
            //w.WriteUInt32(0x00);
            byte[] reply = w.ToArray();
            string fileLocation = Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), "createchar.txt");
            File.WriteAllText(fileLocation, BitConverter.ToString(reply));
            return reply;
        }
        #endregion
        #region New Inventory
        public List<BaseGameItem> GenerateNewInventory()
        {
            // Armor has 20 bytes
            // wepons 21 bytes
            // all other 19 bytes no equip byte
            List<BaseGameItem> inv = new List<BaseGameItem>();
            //uint itemID = 0;
            #region New Gear
            #region Helm
            Item helm = new Item();
            helm.GraphicID = 1242;
            helm.Color = 43;
            helm.Equipped = true;
            helm.UpdateID(ServerGlobals.GetNextAvailableID());
            helm.SqlOwnerID = this.SqlCharId;
            helm.EquipableSlot = EquipmentSlot.Head;
            helm.ArmorFactor = 45;
            helm.Durability = 100;
            helm.LookAt = "This is the long sought after Hood of Shifting, you got one, i would keep it a secret if i were you.";
            helm.Type = ItemType.Armour;
            helm.IsIdentified = true;
            inv.Add(helm);

            Item cowl = new Item();
            cowl.GraphicID = 1524;
            cowl.Color = 43;
            cowl.Equipped = true;
            cowl.UpdateID(ServerGlobals.GetNextAvailableID());
            cowl.SqlOwnerID = this.SqlCharId;
            cowl.EquipableSlot = EquipmentSlot.Cowl;
            cowl.ArmorFactor = 25;
            cowl.Durability = 100;
            cowl.LookAt = "You see the legendary Thurisaz Cowl, best when its the only thing worn.";
            cowl.Type = ItemType.Armour;
            cowl.IsIdentified = true;
            inv.Add(cowl);

            Item chest = new Item();
            chest.GraphicID = 1160;// 1531 fin wrists
            chest.Color = 43;
            chest.Equipped = true;
            chest.UpdateID(ServerGlobals.GetNextAvailableID());
            chest.SqlOwnerID = this.SqlCharId;
            chest.EquipableSlot = EquipmentSlot.Chest;
            chest.ArmorFactor = 135;
            chest.Durability = 100;
            chest.LookAt = "You see a Champion Tunic, only the bravest in the realm obtain these.";
            chest.Type = ItemType.Armour;
            chest.IsIdentified = true;
            inv.Add(chest);

            Item wrist = new Item();
            wrist.GraphicID = 1531;// fin wrists
            wrist.Color = 43;
            wrist.Equipped = true;
            wrist.UpdateID(ServerGlobals.GetNextAvailableID());
            wrist.SqlOwnerID = this.SqlCharId;
            wrist.EquipableSlot = EquipmentSlot.Wrists;
            wrist.ArmorFactor = 35;
            wrist.Durability = 100;
            wrist.LookAt = "A pair of Finvarra's Bracers, strong and durable, a must for any serious warrior.";
            wrist.Type = ItemType.Armour;
            wrist.IsIdentified = true;
            inv.Add(wrist);

            Item legs = new Item();
            legs.GraphicID = 1503;
            legs.Color = 43;
            legs.Equipped = true;
            legs.UpdateID(ServerGlobals.GetNextAvailableID());
            legs.SqlOwnerID = this.SqlCharId;
            legs.EquipableSlot = EquipmentSlot.Legs;
            legs.ArmorFactor = 85;
            legs.Durability = 100;
            legs.LookAt = "Magistrate's Leggings, who said judges wear nothing under their robes!";
            legs.Type = ItemType.Armour;
            legs.IsIdentified = true;
            inv.Add(legs);

            Item feet = new Item();
            feet.GraphicID = 1595;
            feet.Color = 43;
            feet.Equipped = true;
            feet.UpdateID(ServerGlobals.GetNextAvailableID());
            feet.SqlOwnerID = this.SqlCharId;
            feet.EquipableSlot = EquipmentSlot.Feet;
            feet.ArmorFactor = 25;
            feet.Durability = 100;
            feet.LookAt = "A pair of Boots of Evasion, you'll never catch me now!";
            feet.Type = ItemType.Armour;
            feet.IsIdentified = true;
            inv.Add(feet);

            Item belt = new Item();
            belt.GraphicID = 1538;
            belt.Color = 43;
            belt.Equipped = true;
            belt.UpdateID(ServerGlobals.GetNextAvailableID());
            belt.SqlOwnerID = this.SqlCharId;
            belt.EquipableSlot = EquipmentSlot.Belt;
            belt.ArmorFactor = 5;
            belt.Durability = 100;
            belt.LookAt = "A Belt of Carrying, your ready to help a friend move now!";
            belt.Type = ItemType.Armour;
            belt.IsIdentified = true;
            inv.Add(belt);

            // 1 hand wepon
            Item wep = new Item();
            wep.GraphicID = 1577;
            wep.Color = 43;
            wep.Equipped = true;
            wep.UpdateID(ServerGlobals.GetNextAvailableID());
            wep.SqlOwnerID = this.SqlCharId;
            wep.EquipableSlot = EquipmentSlot.Weapon;
            wep.ArmorFactor = 0;
            wep.MinimumDamage = 344;
            wep.MaximumDamage = 1024;
            wep.Durability = 100;
            wep.LookAt = "The powerful Spirit Sword, your enemies will quake with fear now!";
            wep.Type = ItemType.Weapon;
            wep.IsIdentified = true;
            inv.Add(wep);
            // shield
            Item shield = new Item();
            shield.GraphicID = 1600;
            shield.Color = 43;
            shield.Equipped = true;
            shield.UpdateID(ServerGlobals.GetNextAvailableID());
            shield.SqlOwnerID = this.SqlCharId;
            shield.EquipableSlot = EquipmentSlot.Shield;
            shield.ArmorFactor = 95;
            shield.Durability = 100;
            shield.LookAt = "The Amazing Shield of Infinite Though, you feel smarter just looking at it.";
            shield.Type = ItemType.Armour;
            shield.IsIdentified = true;
            inv.Add(shield);
            // Baldric
            Item bald = new Item();
            bald.GraphicID = 1609;
            bald.Color = 43;
            bald.Equipped = true;
            bald.UpdateID(ServerGlobals.GetNextAvailableID());
            bald.SqlOwnerID = this.SqlCharId;
            bald.EquipableSlot = EquipmentSlot.Baldric;
            bald.ArmorFactor = 5;
            bald.Durability = 100;
            bald.LookAt = "A Thistlebark Sash, refinement and class all wrapped up in a bow.";
            bald.Type = ItemType.Outerwear;
            bald.IsIdentified = true;
            inv.Add(bald);
            // Jewlery
            // ammy
            Item ammy = new Item();
            ammy.GraphicID = 1803;
            ammy.Color = 43;
            ammy.Equipped = true;
            ammy.UpdateID(ServerGlobals.GetNextAvailableID());
            ammy.SqlOwnerID = this.SqlCharId;
            ammy.EquipableSlot = EquipmentSlot.Necklace;
            ammy.ArmorFactor = 0;
            ammy.Durability = 100;
            ammy.LookAt = "The Amulet of Stealth, if you misplace this, you will probably never find it.";
            ammy.Type = ItemType.Jewlery;
            ammy.IsIdentified = true;
           // inv.Add(ammy);
            // right ring
            Item rring = new Item();
            rring.GraphicID = 1610;
            rring.Color = 43;
            rring.Equipped = true;
            rring.UpdateID(ServerGlobals.GetNextAvailableID());
            rring.SqlOwnerID = this.SqlCharId;
            rring.EquipableSlot = EquipmentSlot.RightRing;
            rring.ArmorFactor = 0;
            rring.Durability = 100;
            rring.LookAt = "A Ring of Destruction, it hurts your finger just a little.";
            rring.Type = ItemType.Jewlery;
            rring.IsIdentified = true;
            inv.Add(rring);

            Item lring = new Item();
            lring.GraphicID = 1610;
            lring.Color = 43;
            lring.Equipped = true;
            lring.UpdateID(ServerGlobals.GetNextAvailableID());
            lring.SqlOwnerID = this.SqlCharId;
            lring.EquipableSlot = EquipmentSlot.LeftRing;
            lring.ArmorFactor = 0;
            lring.Durability = 100;
            lring.LookAt = "A Ring of Destruction, it hurts your finger just a little.";
            lring.Type = ItemType.Jewlery;
            lring.IsIdentified = true;
            inv.Add(lring);
            // bp

            Container bp = new Container(); // still no good
            bp.GraphicID = 1470;
            bp.Color = 43;
            bp.Equipped = true;
            bp.GameID = ServerGlobals.GetNextAvailableID();
            bp.SqlOwnerID = this.SqlCharId;
            bp.EquipableSlot = EquipmentSlot.Backpack;
            bp.ArmorFactor = 0;
            bp.Durability = 100;
            bp.LookAt = "A Backpack of holding, you can stick all your stuff in here.";
            bp.Type = ItemType.Container;
            bp.IsIdentified = true;
           // inv.Add(bp);

            // Robe
            Item robe = new Item();
            robe.GraphicID = 1539;
            robe.Color = 43;
            robe.Equipped = false;
            robe.UpdateID(ServerGlobals.GetNextAvailableID());
            robe.SqlOwnerID = this.SqlCharId;
            robe.EquipableSlot = EquipmentSlot.Robe;
            robe.ArmorFactor = 0;
            robe.Durability = 100;
            robe.LookAt = "The Mage's Robe, you may not be a mage, but it still looks good.";
            robe.Type = ItemType.Outerwear;
            robe.IsIdentified = true;
            inv.Add(robe);
            #endregion

            #endregion

            // add to sql
            foreach (BaseGameItem item in inv)
            {
                bool add = MySqlManager.SaveItem(this.SqlCharId, item);
                if (!add) Console.WriteLine("Error saving item {0}", item.SqlID);
                //Console.WriteLine("New item {0} for charid {1} saved {2}", item.Name, this.CharId, add);
            }
        // Ok load them properly now
            this.Inventory = MySqlManager.LoadItems(this.SqlCharId);
            return inv;
        }
        #endregion
        #region Create New Char
        public byte[] CreateNewChar56(uint accountId)
        {
            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(accountId);
            writer.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0x00, 
                                     0x38, 0x00, 0x00, 0x00, 
                                     0x55, 0x03, 0x07, 0x0A});
            return writer.ToArray();
        }
        #endregion
        #region Look at packet 58 0x3A (Messy but working as intended.)
        public byte[] CreateLookAt58(uint accountId)
        {
            // If this is player looking at himself
            // looking at others is diff
            

            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(accountId);
            writer.WriteInt32(0x00);
            writer.WriteInt32(0x3A);
            writer.WriteInt32(0x00);
           // string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "look.txt");
           // byte[] file = RealmPacketIO.GetByteArrayFromFileInBaseDir(fileLocation);
           // writer.WriteBytes(file);
           
            #region Old Way
            
            writer.WriteByte(0x2A); // I Dunno maybe how long till u cn turn pvp off ?
            writer.WriteByte(this.Strength);
            writer.WriteByte(this.Dexterity);
            writer.WriteByte(this.Intelligence);
            writer.WriteByte(this.Constitution);
            writer.WriteUInt32((uint)this.Gold);
            writer.WriteUInt32((uint)this.Mana);
            writer.WriteUShort(this.Level);
            writer.WriteByte(this.Alignment);
            writer.WriteInt32(this.CurrentHP);
            writer.WriteInt32(this.TotalHP);
            writer.WriteString(this.Title);
            // Need to fix this !!! TODO
            writer.WriteInt32(this.CurrentXP); // current XP

            // checked with 1's
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            //writer.WriteInt32(0x00); // dunno
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            //writer.WriteInt32(0); // dunno
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            //writer.WriteInt32(0); // dunno
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            //writer.WriteInt32(0); // dunno
            //checked with 1's end

            // We start skills here
            // get them fresh
            CharacterSkills skills = this.GetSkills;
            writer.WriteByte(skills.Short_Sword);
            writer.WriteByte(skills.Long_Sword);

            writer.WriteByte(skills.Two_Handed);
            writer.WriteByte(skills.Dagger);
            writer.WriteByte(skills.Axe);
            writer.WriteByte(skills.Club);
            writer.WriteByte(skills.Mace);
            writer.WriteByte(skills.Unarmed_Combat);
            writer.WriteByte(skills.Throwing);
            writer.WriteByte(skills.Acrobatics);
            writer.WriteByte(skills.Maul);
            writer.WriteByte(skills.Sorcery);
            writer.WriteByte(skills.Elementalism);
            writer.WriteByte(skills.Mysticism);
            writer.WriteByte(skills.Thamaturgy);
            writer.WriteByte(skills.Necromancy);
            writer.WriteByte(skills.Theurgism);
            writer.WriteByte(skills.Alchemy);
            writer.WriteByte(skills.Weaponsmith);
            writer.WriteByte(skills.Armorsmith);
            writer.WriteByte(skills.Unknown1);
            writer.WriteByte(skills.Unknown2);
            writer.WriteByte(skills.Unknown3);
            writer.WriteByte(skills.Unknown4);
            writer.WriteByte(skills.Unknown5);
            writer.WriteByte(skills.Pickpocketing);
            writer.WriteByte(skills.Disarm_Traps);
            writer.WriteByte(skills.Lockpicking);
            writer.WriteByte(skills.Meditation);
            writer.WriteByte(skills.Critical_Strike);
            writer.WriteByte(skills.Shield_Usage);
            writer.WriteByte(skills.Crafting);

            // Done with skills, Spells are next
            CharacterSpells spells = this.GetSpells;
            writer.WriteByte(spells.Home);
            writer.WriteByte(spells.Killstar);
            writer.WriteByte(spells.Unlock);
            writer.WriteByte(spells.Dispell_Magic);
            writer.WriteByte(spells.Engrave);
            writer.WriteByte(spells.Multiblade);
            writer.WriteByte(spells.Gather_The_Fellowship);
            writer.WriteByte(spells.Cornucopia);
            writer.WriteByte(spells.Cloud_Of_Fog);
            writer.WriteByte(spells.Improve_Armor);
            writer.WriteByte(spells.Teleport);
            writer.WriteByte(spells.Extention);
            writer.WriteByte(spells.Invisibility_See);
            writer.WriteByte(spells.Shift);
            writer.WriteByte(spells.Invisibility);
            writer.WriteByte(spells.Teleport_Combat);
            writer.WriteByte(spells.Teleport_Group);
            writer.WriteByte(spells.Permanency);
            writer.WriteByte(spells.Rust);
            writer.WriteByte(spells.Defencelessness);
            writer.WriteByte(spells.Invisibility_Improved);
            writer.WriteByte(spells.Enchant_Item);
            writer.WriteByte(spells.Mass_Rust);
            writer.WriteByte(spells.Elphames_Justice);
            writer.WriteByte(spells.Fire_Grasp);
            writer.WriteByte(spells.Flame_Orb);
            writer.WriteByte(spells.Arctic_Grasp);
            writer.WriteByte(spells.Ice_Orb);
            writer.WriteByte(spells.Earth_Spike);
            writer.WriteByte(spells.Incinerate);
            writer.WriteByte(spells.Gust_Of_Wind);
            writer.WriteByte(spells.Immolation);
            writer.WriteByte(spells.Dancing_Flame);
            writer.WriteByte(spells.Flame_Blade);
            writer.WriteByte(spells.Electric_Charge);
            writer.WriteByte(spells.Cold_Steel);
            writer.WriteByte(spells.Sandstorm);
            writer.WriteByte(spells.Spark);
            writer.WriteByte(spells.Ice_Storm);
            writer.WriteByte(spells.Freezing_Wind);
            writer.WriteByte(spells.Hurricane);
            writer.WriteByte(spells.Crawling_Charge);
            writer.WriteByte(spells.Stoning);
            writer.WriteByte(spells.Fireball);
            writer.WriteByte(spells.Lightning_Bolt);
            writer.WriteByte(spells.Freeze);
            writer.WriteByte(spells.Crushing_Boulder);
            writer.WriteByte(spells.Electric_Fury);
            writer.WriteByte(spells.Cold_Snap);
            writer.WriteByte(spells.Earth_Quake);
            writer.WriteByte(spells.Despothes_Wrath);
            writer.WriteByte(spells.Hold_Monster);
            writer.WriteByte(spells.Fumble);
            writer.WriteByte(spells.Psychic_Orb);
            writer.WriteByte(spells.Confusion);
            writer.WriteByte(spells.Forget);
            writer.WriteByte(spells.Mind_Shackle);
            writer.WriteByte(spells.Identify);
            writer.WriteByte(spells.Berzerk);
            writer.WriteByte(spells.Stun);
            writer.WriteByte(spells.Loyalty_Shift);
            writer.WriteByte(spells.Warp_Mind);
            writer.WriteByte(spells.Etherealize);
            writer.WriteByte(spells.Spell_Blast);
            writer.WriteByte(spells.Mass_Hold);
            writer.WriteByte(spells.Unknown1); //1
            writer.WriteByte(spells.Mass_Fumble);
            writer.WriteByte(spells.Fear);
            writer.WriteByte(spells.Iron_Chains);
            writer.WriteByte(spells.Mass_Berzerk);
            writer.WriteByte(spells.Mass_Stun);
            writer.WriteByte(spells.Mass_Loyalty_Shift);
            writer.WriteByte(spells.Mabons_Forced_Flee);
            writer.WriteByte(spells.Illusionary_Foe);
            writer.WriteByte(spells.Anti_Magic_Aura);
            writer.WriteByte(spells.Light_Dart);
            writer.WriteByte(spells.Curse_Of_Clumsiness);
            writer.WriteByte(spells.Nimbility);
            writer.WriteByte(spells.Empower);
            writer.WriteByte(spells.Enfeeble);
            writer.WriteByte(spells.Missle_Resistance);
            writer.WriteByte(spells.Heal);
            writer.WriteByte(spells.Summon_Pixie);
            writer.WriteByte(spells.Purify);
            writer.WriteByte(spells.Cure_Poison);
            writer.WriteByte(spells.Unknown2); //2
            writer.WriteByte(spells.Heal_Greater);
            writer.WriteByte(spells.Remove_Curse);
            writer.WriteByte(spells.Summon_Fairy);
            writer.WriteByte(spells.Curse_Fire);
            writer.WriteByte(spells.Curse_Cold);
            writer.WriteByte(spells.Curse_Electric);
            writer.WriteByte(spells.Shield);
            writer.WriteByte(spells.Shield_Greater);
            writer.WriteByte(spells.Wrath_Of_The_Gods);
            writer.WriteByte(spells.Shield_Fire);
            writer.WriteByte(spells.Shield_Cold);
            writer.WriteByte(spells.Shield_Lightning);
            writer.WriteByte(spells.Summon_Nymph);
            writer.WriteByte(spells.Regeneration);
            writer.WriteByte(spells.Indestruction);
            writer.WriteByte(spells.Invulnerability);
            writer.WriteByte(spells.Enids_Blessing);
            writer.WriteByte(spells.Banishment);
            writer.WriteByte(spells.Summon_Fairy_Queen);
            writer.WriteByte(spells.Acid_Sphere);
            writer.WriteByte(spells.Venomous_Touch);
            writer.WriteByte(spells.Unknown3); // 3
            writer.WriteByte(spells.Poison_Bolt);
            writer.WriteByte(spells.Unknown4); // 4
            writer.WriteByte(spells.Drain_Life);
            writer.WriteByte(spells.Acid_Cloud);
            writer.WriteByte(spells.Summon_Zombie);
            writer.WriteByte(spells.Venom);
            writer.WriteByte(spells.Summon_Undead);
            writer.WriteByte(spells.Acid_Rain);
            writer.WriteByte(spells.Night_Friends);
            writer.WriteByte(spells.Steal_Life);
            writer.WriteByte(spells.Unknown5); // 5
            writer.WriteByte(spells.Summon_Doppleganger);
            writer.WriteByte(spells.Death_Touch);
            writer.WriteByte(spells.Banish);
            writer.WriteByte(spells.Shadow_Warrior);
            writer.WriteByte(spells.Summon_Daemon);
            writer.WriteByte(spells.Duachs_Vengence);
            writer.WriteByte(spells.Death_Wish);
            writer.WriteByte(spells.Mass_Drain);
            writer.WriteByte(spells.Curse_Poison);
            writer.WriteByte(spells.Curse_Acid);
            writer.WriteByte(spells.Shield_Poison);
            writer.WriteByte(spells.Shield_Acid);
            writer.WriteByte(spells.Head_Of_Death);
            writer.WriteByte(spells.Identify_Greater);
            writer.WriteByte(spells.Summon_Monster_I);
            writer.WriteByte(spells.Summon_Monster_II);
            writer.WriteByte(spells.Summon_Monster_III);
            writer.WriteByte(spells.Summon_Ratling);
            writer.WriteByte(spells.Summon_Bat);
            writer.WriteByte(spells.Summon_Fenris);
            writer.WriteByte(spells.Summon_Imp);
            writer.WriteByte(spells.Summon_Orge);
            writer.WriteByte(spells.Summon_Troll);
            writer.WriteByte(spells.Summon_Seraph);
            writer.WriteByte(spells.Unknown6);
            writer.WriteByte(spells.Unknown7);
            writer.WriteByte(spells.Unknown8);
            writer.WriteByte(spells.Unknown9);
            writer.WriteByte(spells.Unknown10);
            writer.WriteByte(spells.Heal_Mass);
            writer.WriteByte(spells.Unknown11); // 11
            // Spells complete
            // Affects now
            CharacterAffects affects = this.GetAffects;
            writer.WriteByte(affects.Unarmed_Attack_Fire);
            writer.WriteByte(affects.Unarmed_Attack_Cold);
            writer.WriteByte(affects.Unarmed_Attack_Lightning);
            writer.WriteByte(affects.Unarmed_Attack_Acid);
            writer.WriteByte(affects.Unarmed_Attack_Poison);
            writer.WriteByte(affects.Unknown1); // 1
            writer.WriteByte(affects.Unknown2); // 2
            writer.WriteByte(affects.Unarmed_Attack_Exp_Drain);
            writer.WriteByte(affects.Unarmed_Attack_Exp_Steal);
            writer.WriteByte(affects.Unarmed_Attack_Life_Steal);
            writer.WriteByte(affects.Unarmed_Attack_Rust);
            writer.WriteByte(affects.Can_Hit_Etheral);
            writer.WriteByte(affects.Unarmed_Attack_Stun);
            writer.WriteByte(affects.Unknown3); // 2
            writer.WriteByte(affects.Unknown4); // 3
            writer.WriteByte(affects.Improved_Unarmed_Attack_Damage);
            writer.WriteByte(affects.Can_See_Invis);
            writer.WriteByte(affects.Unknown5); // 4 ?
            writer.WriteByte(affects.Unknown6); // 5
            writer.WriteByte(affects.Defenseless);
            writer.WriteByte(affects.Unknown7); // 6 ?
            writer.WriteByte(affects.Unknown8); //7
            writer.WriteByte(affects.Fire_Immolated);
            writer.WriteByte(affects.Cold_Immolated);
            writer.WriteByte(affects.Acid_Immolated);
            writer.WriteByte(affects.Poison_Immolated);
            writer.WriteByte(affects.Lightning_Immolated);
            writer.WriteByte(affects.Frozen);
            writer.WriteByte(affects.Held);
            writer.WriteByte(affects.Confused);
            writer.WriteByte(affects.Unable_To_Flee_Combat);
            writer.WriteByte(affects.Unknown9); // 8
            writer.WriteByte(affects.Berzerked);
            writer.WriteByte(affects.Stunned);
            writer.WriteByte(affects.Unknown10); // 9
            writer.WriteByte(affects.Scared);
            writer.WriteByte(affects.Quickened);
            writer.WriteByte(affects.Slowed);
            writer.WriteByte(affects.Empowered);
            writer.WriteByte(affects.Enfeebled);
            writer.WriteByte(affects.Shielded);
            writer.WriteByte(affects.Shielded2);
            writer.WriteByte(affects.Invulnerable);
            writer.WriteByte(affects.Regenerating);
            writer.WriteByte(affects.Unknown11); // 10
            writer.WriteByte(affects.Cursed);
            writer.WriteByte(affects.Rotting_In_Jail);
            writer.WriteByte(affects.Resistant_To_Magic);
            writer.WriteByte(affects.Immune_To_Magic);
            writer.WriteByte(affects.Rust_Immolated);
            writer.WriteByte(affects.Unknown12); // 11
            writer.WriteByte(affects.Unknown13); // 12
            writer.WriteByte(affects.Resurrecting_25);
            writer.WriteByte(affects.Resurrecting_50);
            writer.WriteByte(affects.Resurrecting_100);
            writer.WriteByte(affects.Extra_Attack);
            writer.WriteByte(affects.Extra_Dodge);
            writer.WriteByte(affects.Spell_Memory_Protected);
            writer.WriteByte(affects.Heightened_Dexterity);
            writer.WriteByte(affects.Lowered_Dexterity);
            writer.WriteByte(affects.Heightened_Intelligence);
            writer.WriteByte(affects.Lowered_Intelligence);
            writer.WriteByte(affects.Heightened_Endurance);
            writer.WriteByte(affects.Lowered_Endurance);
            writer.WriteByte(affects.Retention);
            writer.WriteByte(affects.Vulnerable);
            writer.WriteByte(affects.Nourished);
            writer.WriteByte(affects.Changed_Gender);
            writer.WriteByte(affects.Naked);
            writer.WriteByte(affects.Ugly);
            writer.WriteByte(affects.Disguised);
            writer.WriteByte(affects.Encumberance_Bonus);
            writer.WriteByte(affects.Encumberance_Penalty);
            writer.WriteByte(affects.Unknown14); // 13
            writer.WriteByte(affects.Shifting);
            writer.WriteByte(affects.Spell_Extention);
            writer.WriteByte(affects.Poisoned);
            writer.WriteByte(affects.Acid_Burned);
            writer.WriteByte(affects.Unknown15);
            writer.WriteByte(affects.Unknown16);
            writer.WriteByte(affects.Unknown17);
            writer.WriteByte(affects.Unknown18);
            writer.WriteByte(affects.Unknown19);
            writer.WriteByte(affects.Unknown20); // 19
            writer.WriteByte(affects.Protected_From_Death_Magic);
            writer.WriteByte(affects.Magical_Will_Increase);
            writer.WriteByte(affects.Unknown21);
            writer.WriteByte(affects.Unknown22);
            writer.WriteByte(affects.Unknown23);
            writer.WriteByte(affects.Unknown24);
            writer.WriteByte(affects.Unknown25);
            writer.WriteByte(affects.Unknown26);
            writer.WriteByte(affects.Unknown27);
            writer.WriteByte(affects.Unknown28);
            writer.WriteByte(affects.Unknown29);
            writer.WriteByte(affects.Unknown30);
            writer.WriteByte(affects.Unknown31);
            writer.WriteByte(affects.Unknown32);
            writer.WriteByte(affects.Unknown33);
            // Build Points
            writer.WriteShort((short)this.BuildPoints);
            short rating = 0;
            foreach (BaseGameItem b in this.Inventory)
            {
                if (b.Equipped == true)
                    rating += b.ArmorFactor;
            }

            writer.WriteShort(rating); // armour rating
            writer.WriteByte(this.PvpSwitch); // pvp switch
            writer.WriteByte(0x00);
            
             
#endregion
            return writer.ToArray();
        }
        #endregion
        #region LookAt 55 (0x37) Completed
        public byte[] CreateLookAt55(uint accountId)
        {
            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(accountId);
            writer.WriteInt32(0);
            writer.WriteInt32(0x37);
            writer.WriteInt32(0);
            writer.WriteString(this.Biography);
            return writer.ToArray();
        }
        #endregion
        // TODO : Fix for new stuff
        #region Look at 116 0x74 (Done for the most part)
        public byte[] CreateLookAt116(uint acctID)
        {
            // create lookat for this char
            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(acctID);
            writer.WriteInt32(0);
            writer.WriteInt32(0x74);
            writer.WriteInt32(0);

            #region Helm
            BaseGameItem helm = this.GetEquipedItem(EquipmentSlot.Head);
            if (string.IsNullOrEmpty(helm.Name))
                writer.WriteString(BaseItem.GetBaseItemName(helm.GraphicID, ItemType.Armour));
            else writer.WriteString(helm.Name);

            //writer.WriteString("Blank Helm");
            writer.WriteShort(helm.ArmorFactor); // ar
            writer.WriteShort(helm.Durability); // dur
            #endregion
            #region Cowl
            BaseGameItem cowl = this.GetEquipedItem(EquipmentSlot.Cowl);
            if (string.IsNullOrEmpty(cowl.Name))
                writer.WriteString(BaseItem.GetBaseItemName(cowl.GraphicID, ItemType.Armour));
            else writer.WriteString(cowl.Name);
            writer.WriteShort(cowl.ArmorFactor); // ar
            writer.WriteShort(cowl.Durability); // dur
            #endregion
            #region Chest
            BaseGameItem chest = this.GetEquipedItem(EquipmentSlot.Chest);
            if (string.IsNullOrEmpty(chest.Name))
                writer.WriteString(BaseItem.GetBaseItemName(chest.GraphicID, ItemType.Armour));
            else writer.WriteString(chest.Name);
            writer.WriteShort(chest.ArmorFactor); // ar
            writer.WriteShort(chest.Durability); // dur
            #endregion
            #region Wrist
            BaseGameItem wrist = this.GetEquipedItem(EquipmentSlot.Wrists);
            if (string.IsNullOrEmpty(wrist.Name))
                writer.WriteString(BaseItem.GetBaseItemName(wrist.GraphicID, ItemType.Armour));
            else writer.WriteString(wrist.Name);
            writer.WriteShort(wrist.ArmorFactor); // ar
            writer.WriteShort(wrist.Durability); // dur
            #endregion
            #region Pants
            BaseGameItem pants = this.GetEquipedItem(EquipmentSlot.Legs);
            if (string.IsNullOrEmpty(pants.Name))
                writer.WriteString(BaseItem.GetBaseItemName(pants.GraphicID, ItemType.Armour));
            else writer.WriteString(pants.Name);
            writer.WriteShort(pants.ArmorFactor); // ar
            writer.WriteShort(pants.Durability); // dur
            #endregion
            #region Feet
            BaseGameItem feet = this.GetEquipedItem(EquipmentSlot.Feet);
            if (string.IsNullOrEmpty(feet.Name))
                writer.WriteString(BaseItem.GetBaseItemName(feet.GraphicID, ItemType.Armour));
            else writer.WriteString(feet.Name);
            writer.WriteShort(feet.ArmorFactor); // ar
            writer.WriteShort(feet.Durability); // dur
            #endregion
            #region Shield
            BaseGameItem shield = this.GetEquipedItem(EquipmentSlot.Shield);
            if (string.IsNullOrEmpty(shield.Name))
                writer.WriteString(BaseItem.GetBaseItemName(shield.GraphicID, ItemType.Armour));
            else writer.WriteString(shield.Name);
            writer.WriteShort(shield.ArmorFactor); // ar
            writer.WriteShort(shield.Durability); // dur
            #endregion
            #region Wep
            BaseGameItem wep = this.GetEquipedItem(EquipmentSlot.Weapon);
            if (string.IsNullOrEmpty(wep.Name))
                writer.WriteString(BaseItem.GetBaseItemName(wep.GraphicID, ItemType.Weapon));
            else writer.WriteString(wep.Name);
            writer.WriteShort(wep.MinimumDamage); // low hits
            writer.WriteShort(wep.MaximumDamage);//(100); // high hits
            writer.WriteShort(wep.Durability); // dur
            #endregion
            // States Screen
            // get our states
            CharacterStates s = MySqlManager.LoadStates(this.SqlCharId);
            writer.WriteByte(s.Attacks_Per_Round);
            writer.WriteByte(s.Dodges_Per_Round);
            writer.WriteByte(s.Blocks_Per_Round);
            writer.WriteUShort(s.Damage_Attack_Low);
            writer.WriteUShort(s.Damage_Attack_High);
            writer.WriteByte(s.Movement_Rate);
            writer.WriteUShort(s.Encumberance_Low);
            writer.WriteUShort(s.Encumberance_High);
            // Nada
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            writer.WriteByte(0x00);
            //
            writer.WriteInt32(s.Kills_Good);
            writer.WriteInt32(s.Kills_Evil);
            writer.WriteInt32(s.Mana_Drain);
            writer.WriteInt32(s.Armor_Pierce);
            writer.WriteInt32(s.Evil_Mdm);
            writer.WriteInt32(s.Good_Mdm);
            // This needs to be formatted better
            // Spellresists
            writer.WriteString(s.Spell_Resists);
            // Cast Resists
            writer.WriteString(s.Cast_Resists);
            //Account type, may only allow 7 chars

            while (s.Account_Type.Length < 7)
            {
                s.Account_Type = s.Account_Type + " ";
                if (s.Account_Type.Length == 7) break;
            }
            writer.WriteString(s.Account_Type);
            
            int  d =(int)MagicMail.DateTimeToUnixTimestamp(DateTime.Now);
            writer.WriteInt32(d); // datetime
            writer.WriteInt32(10000000); // dont care how much, its at 2037 now
 
            writer.WriteInt32(11326753);
            // Referal Code may have to be 7 bytes
            while (s.Referal_Code.Length < 7)
            {
                s.Referal_Code = s.Referal_Code + " ";
                if (s.Referal_Code.Length == 7) break;
            }
            writer.WriteString(s.Referal_Code);
            // 1 = Norseman Staff
            // 2 = In Game Staff
            Account a = ServerGlobals.GetAccountFromCharacter(this);
            int plvl = MySqlManager.GetPLevel(a.SqlId);
            if (plvl <= 4)
                writer.WriteByte(0x02);
            else writer.WriteByte(0x00);
 
            writer.WriteShort((short)s.Melee_Dmg_Mod);
            writer.WriteShort((short)s.Spell_Dmg_Mod);
            /*
             * value 4 and above
             * Veteran of The Ages
             */
            // check when this account was created.
            long age = MySqlManager.GetAccountAge(a.SqlId);
            DateTime atime = DateTime.FromBinary(age);

            if(atime.Hour < DateTime.Now.Hour)
            writer.WriteByte(0x04);
            else writer.WriteByte(0x00);
            
            return writer.ToArray();
        }
        #endregion
        #region Login Packet 130
        public byte[] CreateLogin130(uint accountId)
        {
            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(accountId);
            writer.WriteInt32(0x00);
            writer.WriteInt32(0x82);
            writer.WriteInt32(0x00);
            writer.WriteInt32(0x00);
            writer.WriteInt32(0x06);
            writer.WriteShort(0x02);
            writer.WriteShort(0x0A);
            writer.WriteInt32(0);
            return writer.ToArray();
        }
        #endregion
        
        public void ClearIDS()
        {
            foreach (uint id in IDsInUse)
            {
                ServerGlobals.CharacterIDsInUse.Remove(id);
            }
        }
        public CharacterSkills GetSkills
        {
            get
            {
                return MySqlManager.LoadSkills(this.SqlCharId);
            }
        }
        public CharacterSpells GetSpells
        {
            get
            {
                return MySqlManager.LoadSpells(this.SqlCharId);
            }
        }
        public CharacterAffects GetAffects
        {
            get
            {
                return MySqlManager.LoadAffects(this.SqlCharId);
            }
        }
        public override byte[] Serialize(out uint itemID)
        {
            itemID = 0;
            return new byte[0];
        }
        public override void Deserialize(byte[] data)
        {
            //throw new NotImplementedException();
        }
        public BaseGameItem GetEquipedItem(EquipmentSlot slot)
        {
            Item none = new Item();
            none.Name = "None";
            BaseGameItem reply = none;
            foreach (BaseGameItem b in this.Inventory)
            {
                if (b.EquipableSlot == slot && b.Equipped == true)
                {
                    reply = b;
                    break;
                }
            }
            return reply;
        }
    }
}
