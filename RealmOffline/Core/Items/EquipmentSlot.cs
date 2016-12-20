using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items
{
    public enum EquipmentSlot : int
    {
        None = 0,
        Head = 1,
        Cowl = 2,
        Necklace = 3,
        Chest = 4,
        Wrists = 5,
        LeftRing = 6,
        RightRing = 7, // can add more rings if we want
        Belt = 8,
        Legs = 9,
        Feet = 10,
        Shield = 11,
        Weapon = 12,
        Robe = 13,
        Backpack = 14,
        Baldric = 15
    }
    public static class EquipmentSlotConvertor
    {
        public static int ToInt(EquipmentSlot slot)
        {
            return (int)slot;
        }
        public static EquipmentSlot ToEquipmentSlot(int value)
        {
            EquipmentSlot reply = EquipmentSlot.None;
            foreach(EquipmentSlot e in Enum.GetValues(typeof(EquipmentSlot)))
            {
                if((int)e == value)
                {
                    reply = e;
                    break;
                }
            }
            return reply;
        }
    }
}
