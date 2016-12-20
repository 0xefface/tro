using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public enum Races : byte
    {
        Human = 0x00,
        Orc = 0x01,
        Giant = 0x02,
        Elf = 0x03
    }
    public enum Classes : byte
    {
        Adventurer = 0x01,
        Warrior = 0x02,
        Wizard = 0x03,
        Thief = 0x04
    }
}
