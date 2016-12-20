using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Managers;

namespace RealmOffline.Accounts
{
    public class CharacterStates
    {
        public uint CharSqlID { get; set; }
        // We have current items we are wearing, but will pull that from another db
        public byte Attacks_Per_Round { get; set; }
        public byte Dodges_Per_Round { get; set; }
        public byte Blocks_Per_Round { get; set; }
        public ushort Damage_Attack_Low { get; set; }
        public ushort Damage_Attack_High { get; set; }
        public byte Movement_Rate { get; set; }
        public ushort Encumberance_Low { get; set; }
        public ushort Encumberance_High { get; set; }
        public int Kills_Good { get; set; }
        public int Kills_Evil { get; set; }
        public int Mana_Drain { get; set; }
        public int Armor_Pierce { get; set; }
        public int Evil_Mdm { get; set; }
        public int Good_Mdm { get; set; }
        public string Spell_Resists { get; set; }
        public string Cast_Resists { get; set; }
        public string Account_Type { get; set; }
        public ushort Billing_Date { get; set; }
        public ushort Time_Credits { get; set; }
        public int Coppers { get; set; }
        public string Referal_Code { get; set; }
        public ushort Melee_Dmg_Mod { get; set; }
        public ushort Spell_Dmg_Mod { get; set; }

        public CharacterStates(uint sqlId)
        {
            this.CharSqlID = sqlId;
            // Load from sql
        }
        public CharacterStates LoadFromMySql()
        {
            return MySqlManager.LoadStates(this.CharSqlID);
        }
        public bool CreateNewStates()
        {
            return MySqlManager.InsertNewStatess(this.CharSqlID);
        }
    }
}
