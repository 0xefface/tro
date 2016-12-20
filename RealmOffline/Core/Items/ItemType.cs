using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items
{
    public enum ItemType : int
    {
        None = 0,
        Armour = 1,
        Weapon = 2,
        Container = 3,
        Bolt = 4,
        Decorative = 5,
        HairDye = 6,
        Edible = 7,
        Jewlery = 8,
        Book = 9,
        Tool = 10,
        Material = 11,
        Outerwear = 12,
        Chair = 13,
        Consumable = 14
    }
    public static class ItemTypeConvertor
    {
        public static ItemType FromInt(int value)
        {
            foreach(ItemType i in Enum.GetValues(typeof(ItemType)))
            {
                if (ToInt(i) == value) return i;
            }
            return ItemType.None;
        }
        public static int ToInt(ItemType value)
        {
            return (int)value;
        }
    }
}
