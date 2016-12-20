using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RealmOffline.Core
{
    public enum LootType
    {
        Common,
        Normal,
        Magical,
        Rare,
        Uncommon
    }
    public enum PrivLevel: byte
    {
        Player = 0x05,
        EventHost = 0x04,
        Guide = 0x03,
        Sentinal = 0x02,
        GameMaster = 0x01,
        Implementor = 0x00

    }
    [AttributeUsage(AttributeTargets.Class)]
    public class GameItemAttribute : Attribute
    {
        public bool Implemented = true;
        public LootType LootType = LootType.Normal;
        /// <summary>
        /// Sets attributes loottype and implemented
        /// </summary>
        /// <param name="type"></param>
        /// <param name="implemented"></param>
        public GameItemAttribute(LootType type, bool implemented = true)
        {
            this.LootType = type;
            this.Implemented = implemented;
        }
        /// <summary>
        /// Just sets implemented or not, 
        /// returns default value of normal for type
        /// </summary>
        /// <param name="implemented"></param>
        public GameItemAttribute(bool implemented = true)
        {
            this.Implemented = implemented;
        }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class RequiredPrivledgeAttribute : Attribute
    {
        public PrivLevel PrivledgeLevel = PrivLevel.Player;
        public RequiredPrivledgeAttribute(PrivLevel level)
        {
            this.PrivledgeLevel = level;
        }
    }
}