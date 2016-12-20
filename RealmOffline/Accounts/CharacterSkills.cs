using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Managers;

namespace RealmOffline.Accounts
{
    public class CharacterSkills
    {
        public uint CharSqlID { get; set; }
        public byte Short_Sword { get; set; }
        public byte Long_Sword { get; set; }
        public byte Two_Handed { get; set; }
        public byte Dagger { get; set; }
        public byte Axe { get; set; }
        public byte Club { get; set; }
        public byte Mace { get; set; }
        public byte Unarmed_Combat { get; set; }
        public byte Throwing { get; set; }
        public byte Acrobatics { get; set; }
        public byte Maul { get; set; }
        public byte Sorcery { get; set; }
        public byte Elementalism { get; set; }
        public byte Mysticism { get; set; }
        public byte Thamaturgy { get; set; }
        public byte Necromancy { get; set; }
        public byte Theurgism { get; set; }
        public byte Alchemy { get; set; }
        public byte Weaponsmith { get; set; }
        public byte Armorsmith { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Pickpocketing { get; set; }
        public byte Disarm_Traps { get; set; }
        public byte Lockpicking { get; set; }
        public byte Meditation { get; set; }
        public byte Critical_Strike { get; set; }
        public byte Shield_Usage { get; set; }
        public byte Crafting { get; set; }


        /// <summary>
        /// Loads char skills by sql char id.
        /// </summary>
        /// <param name="sqlCharID">the id assigned to the char in caracters db</param>
        public CharacterSkills(uint sqlCharID)
        {
            this.CharSqlID = sqlCharID;
            // Load
        }
        public CharacterSkills LoadFromMySql()
        {
            return MySqlManager.LoadSkills(this.CharSqlID);
        }
        public bool CreateNewSkillsSetByClass(byte pClass, byte pAlignment)
        {
            if (!MySqlManager.InsertNewSkills(this.CharSqlID)) { return false; }
            bool valid = false;
            switch (pClass)
            {
                case 0: // Adven
                    {
                        MySqlManager.SetSkill(this.CharSqlID, "Short_Sword", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Sorcery", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Thaumaturgy", 1);
                        valid = true;
                        // Need to add skills by algnment too
                    }
                    break;
                case 1: // Warrior
                    {
                        MySqlManager.SetSkill(this.CharSqlID, "Short_Sword", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Long_Sword", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Unarmed_Combat", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Sorcery", 1);
                        valid = true;
                    }
                    break;
                case 2: // Wiz
                    {
                        MySqlManager.SetSkill(this.CharSqlID, "Dagger", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Sorcery", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Thaumaturgy", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Acrobatics", 1);
                        valid = true;
                    }
                    break;
                case 3: // Thief
                    {
                        MySqlManager.SetSkill(this.CharSqlID, "Dagger", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Sorcery", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Throwing", 1);
                        MySqlManager.SetSkill(this.CharSqlID, "Acrobatics", 1);
                        valid = true;
                    }
                    break;
            }
            return valid;
        }
    }
}
