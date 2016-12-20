using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Packets
{
    public static class ClassType
    {
        public static ushort Get(byte fromClass)
        {
            switch (fromClass)
            {
                    // 3585 ? 01, 0E ?
                case 0: return 1793;
                case 1: return 2049;
                case 2: return 2305;
                case 3: return 2561;
                default: return 1793; // force adv 
            }
        }
    }
}
