using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Managers;

namespace RealmOffline.Accounts
{
    public class CharacterSpells
    {
        public uint CharSqlID { get; set; }
        #region All Known Spell Slots
        public byte Home { get; set; }
        public byte Killstar { get; set; }
        public byte Unlock { get; set; }
        public byte Dispell_Magic { get; set; }
        public byte Engrave { get; set; }
        public byte Multiblade { get; set; }
        public byte Gather_The_Fellowship { get; set; }
        public byte Cornucopia { get; set; }
        public byte Cloud_Of_Fog { get; set; }
        public byte Improve_Armor { get; set; }
        public byte Teleport { get; set; }
        public byte Extention { get; set; }
        public byte Invisibility_See { get; set; }
        public byte Shift { get; set; }
        public byte Invisibility { get; set; }
        public byte Teleport_Combat { get; set; }
        public byte Teleport_Group { get; set; }
        public byte Permanency { get; set; }
        public byte Rust { get; set; }
        public byte Defencelessness { get; set; }
        public byte Invisibility_Improved { get; set; }
        public byte Enchant_Item { get; set; }
        public byte Mass_Rust { get; set; }
        public byte Elphames_Justice { get; set; }
        public byte Fire_Grasp { get; set; }
        public byte Flame_Orb { get; set; }
        public byte Arctic_Grasp { get; set; }
        public byte Ice_Orb { get; set; }
        public byte Earth_Spike { get; set; }
        public byte Incinerate { get; set; }
        public byte Gust_Of_Wind { get; set; }
        public byte Immolation { get; set; }
        public byte Dancing_Flame { get; set; }
        public byte Flame_Blade { get; set; }
        public byte Electric_Charge { get; set; }
        public byte Cold_Steel { get; set; }
        public byte Sandstorm { get; set; }
        public byte Spark { get; set; }
        public byte Ice_Storm { get; set; }
        public byte Freezing_Wind { get; set; }
        public byte Hurricane { get; set; }
        public byte Crawling_Charge { get; set; }
        public byte Stoning { get; set; }
        public byte Fireball { get; set; }
        public byte Lightning_Bolt { get; set; }
        public byte Freeze { get; set; }
        public byte Crushing_Boulder { get; set; }
        public byte Electric_Fury { get; set; }
        public byte Cold_Snap { get; set; }
        public byte Earth_Quake { get; set; }
        public byte Despothes_Wrath { get; set; }
        public byte Hold_Monster { get; set; }
        public byte Fumble { get; set; }
        public byte Psychic_Orb { get; set; }
        public byte Confusion { get; set; }
        public byte Forget { get; set; }
        public byte Mind_Shackle { get; set; }
        public byte Identify { get; set; }
        public byte Berzerk { get; set; }
        public byte Stun { get; set; }
        public byte Loyalty_Shift { get; set; }
        public byte Warp_Mind { get; set; }
        public byte Etherealize { get; set; }
        public byte Spell_Blast { get; set; }
        public byte Mass_Hold { get; set; }
        public byte Unknown1 { get; set; }
        public byte Mass_Fumble { get; set; }
        public byte Fear { get; set; }
        public byte Iron_Chains { get; set; }
        public byte Mass_Berzerk { get; set; }
        public byte Mass_Stun { get; set; }
        public byte Mass_Loyalty_Shift { get; set; }
        public byte Mabons_Forced_Flee { get; set; }
        public byte Illusionary_Foe { get; set; }
        public byte Anti_Magic_Aura { get; set; }
        public byte Light_Dart { get; set; }
        public byte Curse_Of_Clumsiness { get; set; }
        public byte Nimbility { get; set; }
        public byte Empower { get; set; }
        public byte Enfeeble { get; set; }
        public byte Missle_Resistance { get; set; }
        public byte Heal { get; set; }
        public byte Summon_Pixie { get; set; }
        public byte Purify { get; set; }
        public byte Cure_Poison { get; set; }
        public byte Unknown2 { get; set; }
        public byte Heal_Greater { get; set; }
        public byte Remove_Curse { get; set; }
        public byte Summon_Fairy { get; set; }
        public byte Curse_Fire { get; set; }
        public byte Curse_Cold { get; set; }
        public byte Curse_Electric { get; set; }
        public byte Shield { get; set; }
        public byte Shield_Greater { get; set; }
        public byte Wrath_Of_The_Gods { get; set; }
        public byte Shield_Fire { get; set; }
        public byte Shield_Cold { get; set; }
        public byte Shield_Lightning { get; set; }
        public byte Summon_Nymph { get; set; }
        public byte Regeneration { get; set; }
        public byte Indestruction { get; set; }
        public byte Invulnerability { get; set; }
        public byte Enids_Blessing { get; set; }
        public byte Banishment { get; set; }
        public byte Summon_Fairy_Queen { get; set; }
        public byte Acid_Sphere { get; set; }
        public byte Venomous_Touch { get; set; }
        public byte Unknown3 { get; set; }
        public byte Poison_Bolt { get; set; }
        public byte Unknown4 { get; set; }
        public byte Drain_Life { get; set; }
        public byte Acid_Cloud { get; set; }
        public byte Summon_Zombie { get; set; }
        public byte Venom { get; set; }
        public byte Summon_Undead { get; set; }
        public byte Acid_Rain { get; set; }
        public byte Night_Friends { get; set; }
        public byte Steal_Life { get; set; }
        public byte Unknown5 { get; set; }
        public byte Summon_Doppleganger { get; set; }
        public byte Death_Touch { get; set; }
        public byte Banish { get; set; }
        public byte Shadow_Warrior { get; set; }
        public byte Summon_Daemon { get; set; }
        public byte Duachs_Vengence { get; set; }
        public byte Death_Wish { get; set; }
        public byte Mass_Drain { get; set; }
        public byte Curse_Poison { get; set; }
        public byte Curse_Acid { get; set; }
        public byte Shield_Poison { get; set; }
        public byte Shield_Acid { get; set; }
        public byte Head_Of_Death { get; set; }
        public byte Identify_Greater { get; set; }
        public byte Summon_Monster_I { get; set; }
        public byte Summon_Monster_II { get; set; }
        public byte Summon_Monster_III { get; set; }
        public byte Summon_Ratling { get; set; }
        public byte Summon_Bat { get; set; }
        public byte Summon_Fenris { get; set; }
        public byte Summon_Imp { get; set; }
        public byte Summon_Orge { get; set; }
        public byte Summon_Troll { get; set; }
        public byte Summon_Seraph { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Heal_Mass { get; set; }
        public byte Unknown11 { get; set; }
        #endregion

        public CharacterSpells(uint sqlCharID)
        {
            this.CharSqlID = sqlCharID;
            // Load from sql
        }
        public CharacterSpells LoadFromMySql()
        {
            return MySqlManager.LoadSpells(this.CharSqlID);
        }
        public bool CreateNewSpellsSetByClass(byte pClass, byte pAlignment)
        {
            if (!MySqlManager.InsertNewSpells(this.CharSqlID)) { return false; }
            bool valid = false;
            MySqlManager.GiveSpell(this.CharSqlID, "Home");

            switch (pClass)
            {
                case 0: // Adven
                    {                       
                        switch (pAlignment)
                        {
                            case 255: // good
                                MySqlManager.GiveSpell(this.CharSqlID, "Heal");
                                break;
                            case 128: // nuet
                                MySqlManager.GiveSpell(this.CharSqlID, "Killstar");
                                break;
                            case 0:// evil
                                MySqlManager.GiveSpell(this.CharSqlID, "Flame_Orb");
                                break;
                        }
                        valid = true;
                        // Need to add skills by algnment too
                    }
                    break;
                case 1: // Warrior
                    {
                        valid = true;
                    }
                    break;
                case 2: // Wiz
                    {
                        switch (pAlignment)
                        {
                            case 255: // good
                                MySqlManager.GiveSpell(this.CharSqlID, "Heal");
                                break;
                            case 128: // nuet
                                MySqlManager.GiveSpell(this.CharSqlID, "Killstar");
                                break;
                            case 0:// evil
                                MySqlManager.GiveSpell(this.CharSqlID, "Flame_Orb");
                                break;
                        }
                        valid = true;
                    }
                    break;
                case 3: // Thief
                    {
                        switch (pAlignment)
                        {
                            case 255: // good
                                MySqlManager.GiveSpell(this.CharSqlID, "Heal");
                                break;
                            case 128: // nuet
                                MySqlManager.GiveSpell(this.CharSqlID, "Killstar");
                                break;
                            case 0:// evil
                                MySqlManager.GiveSpell(this.CharSqlID, "Flame_Orb");
                                break;
                        }
                        valid = true;
                    }
                    break;
            }
            return valid;
        }
    }
}
