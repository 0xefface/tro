using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Managers;

namespace RealmOffline.Accounts
{
    public class CharacterAffects
    {
        public uint CharSqlID { get; set; }
        public byte Unarmed_Attack_Fire { get; set; }
        public byte Unarmed_Attack_Cold { get; set; }
        public byte Unarmed_Attack_Lightning { get; set; }
        public byte Unarmed_Attack_Acid { get; set; }
        public byte Unarmed_Attack_Poison { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unarmed_Attack_Exp_Drain { get; set; }
        public byte Unarmed_Attack_Exp_Steal { get; set; }
        public byte Unarmed_Attack_Life_Steal { get; set; }
        public byte Unarmed_Attack_Rust { get; set; }
        public byte Can_Hit_Etheral { get; set; }
        public byte Unarmed_Attack_Stun { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Improved_Unarmed_Attack_Damage { get; set; }
        public byte Can_See_Invis { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public byte Defenseless { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Fire_Immolated { get; set; }
        public byte Cold_Immolated { get; set; }
        public byte Acid_Immolated { get; set; }
        public byte Poison_Immolated { get; set; }
        public byte Lightning_Immolated { get; set; }
        public byte Frozen { get; set; }
        public byte Held { get; set; }
        public byte Confused { get; set; }
        public byte Unable_To_Flee_Combat { get; set; }
        public byte Unknown9 { get; set; }
        public byte Berzerked { get; set; }
        public byte Stunned { get; set; }
        public byte Unknown10 { get; set; }
        public byte Scared { get; set; }
        public byte Quickened { get; set; }
        public byte Slowed { get; set; }
        public byte Empowered { get; set; }
        public byte Enfeebled { get; set; }
        public byte Shielded { get; set; }
        public byte Shielded2 { get; set; }
        public byte Invulnerable { get; set; }
        public byte Regenerating { get; set; }
        public byte Unknown11 { get; set; }
        public byte Cursed { get; set; }
        public byte Rotting_In_Jail { get; set; }
        public byte Resistant_To_Magic { get; set; }
        public byte Immune_To_Magic { get; set; }
        public byte Rust_Immolated { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13{ get; set; }
        public byte Resurrecting_25 { get; set; }
        public byte Resurrecting_50 { get; set; }
        public byte Resurrecting_100 { get; set; }
        public byte Extra_Attack { get; set; }
        public byte Extra_Dodge { get; set; }
        public byte Spell_Memory_Protected { get; set; }
        public byte Heightened_Dexterity { get; set; }
        public byte Lowered_Dexterity { get; set; }
        public byte Heightened_Intelligence { get; set; }
        public byte Lowered_Intelligence { get; set; }
        public byte Heightened_Endurance { get; set; }
        public byte Lowered_Endurance { get; set; }
        public byte Retention { get; set; }
        public byte Vulnerable { get; set; }
        public byte Nourished { get; set; }
        public byte Changed_Gender { get; set; }
        public byte Naked { get; set; }
        public byte Ugly { get; set; }
        public byte Disguised { get; set; }
        public byte Encumberance_Bonus { get; set; }
        public byte Encumberance_Penalty { get; set; }
        public byte Unknown14 { get; set; }
        public byte Shifting { get; set; }
        public byte Spell_Extention { get; set; }
        public byte Poisoned { get; set; }
        public byte Acid_Burned { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Protected_From_Death_Magic { get; set; }
        public byte Magical_Will_Increase { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }


        public CharacterAffects(uint sqlId)
        {
            this.CharSqlID = sqlId;
            // Load from sql
        }
        public CharacterAffects LoadFromMySql()
        {
            return MySqlManager.LoadAffects(this.CharSqlID);
        }
        public bool CreateNewAffectsForChar()
        {
            bool valid = MySqlManager.InsertNewAffects(this.CharSqlID);
            if (valid) { MySqlManager.SetAffect(this.CharSqlID, "Rotting_In_Jail"); }
            return valid;
        }

    }
}
