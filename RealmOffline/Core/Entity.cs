using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public abstract class Entity : IEntity
    {
        public abstract uint GameID { get; set; }
        public abstract ushort GraphicID { get; set; }
        public abstract ushort Color { get; set; }
        public abstract string Name { get; set; }
        public RoomLocation Location { get; set; }
        public abstract byte[] Serialize(out uint itemID);
        public abstract void Deserialize(byte[] data);
    }
}
