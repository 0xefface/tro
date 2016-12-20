using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    // 0x53, 0x54, 0x00
    // Extra Attack 0x48
    // heighten endurance 2 bytes 0x3f, 0x3f = 16191 pretty sure max hp
    public static class Spell
    {
        #region Elem (All Known Spells Complete)
        public enum Elementalism : short
        {
            Fire_Grasp = 0x18,
            Flame_Orb = 0x19,
            Artic_Grasp = 0x1A,
            Ice_Orb = 0x1B,
            Earth_Spike = 0x1C,
            Incinerate = 0x1D,
            Gust_of_Wind = 0x1E,
            Immolation = 0x1F,
            Dancing_Flame = 0x20,
            Flame_Blade = 0x21,
            Electric_Charge = 0x22,
            Cold_Steel = 0x23,
            Sandstorm = 0x24,
            Spark = 0x25,
            Ice_Storm = 0x26,
            Freezing_Wind = 0x27,
            Hurricane = 0x28,
            Stoning = 0x2A,
            Fireball = 0x2B,
            Lightning_Bolt = 0x2C,
            Freeze = 0x2D,
            Electric_Fury = 0x2F,
            Earth_Quake = 0x31,
            Head_of_Death = 0x83,
            Summon_Ratling = 0x88,
            Summon_Bat = 0x89,
            Summon_Fenris = 0x8A,
            Summon_Imp = 0x8B,
            Summon_Orge = 0x8C,
            Summon_Troll = 0x8D,
            Summon_Seraph = 0x8E
        }
        #endregion
        #region Myst (All Known Spells Complete)
        public enum Mysticsim : short
        {
            Hold_Monster = 0x33,
            Fumble = 0x34,
            Psychic_Orb = 0x35,
            Confusion = 0x36,
            Forget = 0x37,
            Mind_Shackle = 0x38,
            Identify = 0x39,
            Berzerk = 0x3A,
            Stun = 0x3B,
            Loyalty_Shift = 0x3C,
            Warp_Mind = 0x3D,
            Etherlize = 0x3E,
            Spell_Blast = 0x3F,
            Mass_Hold = 0x40,
            Mass_Fumble = 0x42,
            Fear = 0x43,
            Iron_Chains = 0x44,
            Mass_Berserk = 0x45,
            Mass_Stun = 0x46,
            Mass_Loyalty_Shift = 0x47,
            Mabons_Forced_Flee = 0x48,
            Illusionary_Foe = 0x49,
            Anti_Magic_Aura = 0x4A
        }
        #endregion
        #region Necromancy (All Known Spells Complete)
        public enum Necromancy : short
        {
            Curse_Clumsy = 0x4C,
            Enfeeble = 0x4F,
            Curse_Fire = 0x59,
            Curse_Cold = 0x5A,
            Curse_Electric = 0x5B,
            Acid_Sphere = 0x69,
            Venomous_Touch = 0x6A,
            Poison_Bolt = 0x6C,
            Drain_Life = 0x6E,
            Acid_Cloud = 0x6F,
            Summon_Zombie = 0x70,
            Venom = 0x71,
            Summon_Undead = 0x72,
            Acid_Rain = 0x73,
            Night_Friends = 0x74,
            Steal_Life = 0x75,
            Summon_Doppelganger = 0x77,
            Death_Touch = 0x78,
            Banish = 0x79,
            Shadow_Warrior = 0x7A,
            Summon_Deamon = 0x7B,
            Duachs_Vengeance = 0x7C,
            Death_Wish = 0x7D,
            Mass_Drain = 0x7E,
            Curse_Poison = 0x7F,
            Curse_Acid = 0x80
        }
        #endregion
        #region Sorcery (All Known Complete)
        public enum Sorcery : short
        {
            Home = 0x00,
            Killstar = 0x01,
            Unlock = 0x02,
            Dispell = 0x03,
            Engrave = 0x04,
            Multiblade = 0x05,
            Gather_Fellowship = 0x06,
            Cornicopia = 0x07,
            Cloud_of_Fog = 0x08,
            Improve_Armor = 0x09,
            Teleport = 0x0A,
            Extention = 0x0B,
            See_Invisible = 0x0C,
            Shift = 0x0D,
            Invisibility = 0x0E,
            Teleport_Combat = 0x0F,
            Teleport_Group = 0x10,
            Permanency = 0x11,
            Rust = 0x12,
            Defencelessness = 0x13,
            Improved_Invisibility = 0x14,
            Enchant_Item = 0x15,
            Mass_Rust = 0x16,
            Elphames_Justice = 0x17,
            Identify_Greater = 0x84,
            Summon_Monster_I = 0x85,
            Summon_Monster_II = 0x86,
            Summon_Monster_III = 0x87
        }
        #endregion
        #region Thaum (All Known Complete)
        public enum Thaumaturgy : short
        {
            Light_Dart = 0x4B,
            Nimbility = 0x4D,
            Empower = 0x4E,
            Missle_Resist = 0x50,
            Heal = 0x51,
            Summon_Pixie = 0x52,
            Purify = 0x53,
            Cure_Poison = 0x54,
            Heal_Greater = 0x56,
            Curse_Remove = 0x57,
            Summon_Fairy = 0x58,
            Shield = 0x5C,
            Shield_Greater = 0x5D,
            Wrath_of_the_Gods = 0x5E,
            Shield_Fire = 0x5F,
            Shield_Cold = 0x60,
            Shield_Lightning = 0x61,
            Summon_Nymph = 0x62,
            Regeneration = 0x63,
            Indestruction = 0x64,
            Invunerability = 0x65,
            Enids_Blessing = 0x66,
            Banishment = 0x67,
            Summon_Fairy_Queen = 0x68,
            Shield_Poison = 0x81,
            Shield_Acid = 0x82
        }
        #endregion
    }
    public static class SpellConvertor
    {
        public static Enum FromShort(short value)
        {
            foreach (Spell.Elementalism e in Enum.GetValues(typeof(Spell.Elementalism))) if ((short)e == value) return e;
            foreach (Spell.Mysticsim e in Enum.GetValues(typeof(Spell.Mysticsim))) if ((short)e == value) return e;
            foreach (Spell.Necromancy e in Enum.GetValues(typeof(Spell.Necromancy))) if ((short)e == value) return e;
            foreach (Spell.Sorcery e in Enum.GetValues(typeof(Spell.Sorcery))) if ((short)e == value) return e;
            foreach (Spell.Thaumaturgy e in Enum.GetValues(typeof(Spell.Thaumaturgy))) if ((short)e == value) return e;
            return null;
        }
        public static short SpellEffect(Enum spell)
        {
            if (spell is Spell.Elementalism)
            {
                Spell.Elementalism elem = (Spell.Elementalism)spell;
                switch (elem)
                {
                    case Spell.Elementalism.Artic_Grasp: return 605;
                    case Spell.Elementalism.Cold_Steel: return 598;
                    case Spell.Elementalism.Dancing_Flame: return 628;
                    case Spell.Elementalism.Earth_Quake: return 558;
                    case Spell.Elementalism.Earth_Spike: return 617;
                    case Spell.Elementalism.Electric_Charge: return 597;
                    case Spell.Elementalism.Electric_Fury: return 606;
                    case Spell.Elementalism.Fire_Grasp: return 593;
                    case Spell.Elementalism.Fireball: return 542;
                    case Spell.Elementalism.Flame_Blade: return 596;
                    case Spell.Elementalism.Flame_Orb: return 648;
                    case Spell.Elementalism.Freeze: return 594;
                    case Spell.Elementalism.Freezing_Wind: return 577;
                    case Spell.Elementalism.Gust_of_Wind: return 534;
                    case Spell.Elementalism.Head_of_Death: return 617;
                    case Spell.Elementalism.Hurricane: return 635;
                    case Spell.Elementalism.Ice_Orb: return 598;
                    case Spell.Elementalism.Ice_Storm: return 530;
                    case Spell.Elementalism.Immolation: return 603;
                    case Spell.Elementalism.Incinerate: return 593;
                    case Spell.Elementalism.Lightning_Bolt: return 517;
                    case Spell.Elementalism.Sandstorm: return 541;
                    case Spell.Elementalism.Spark: return 597;
                    case Spell.Elementalism.Stoning: return 615;
                     
                }
            }
            else if (spell is Spell.Mysticsim)
            {
            }
            else if (spell is Spell.Necromancy)
            {
            }
            else if (spell is Spell.Sorcery)
            {
            }
            else if (spell is Spell.Thaumaturgy)
            {
            }
            return 514;
        }
    }
}
