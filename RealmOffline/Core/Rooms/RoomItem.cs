using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Rooms
{
    public enum RoomItemtype : byte
    {
        None = 0x00,
        Interactive = 0x01,
        NonInteractive = 0x02
    }
    public class RoomItem : ISerializable<RoomItem>
    {
        public ushort GraphicID;
        public ushort LocationX;
        public ushort LocationY;
        public ushort LocationZ;
        public RoomItemtype ItemType;

        public RoomItem() // Sets Defaults
        {
            this.GraphicID = 0;
            this.LocationX = 0;
            this.LocationY = 0;
            this.LocationZ = 0;
            this.ItemType = RoomItemtype.NonInteractive;
        }
        public RoomItem(ushort graphicID, RoomItemtype type, ushort locationX, ushort locationY, ushort locationZ = 0)
        {
            this.GraphicID = graphicID;
            this.LocationX = locationX;
            this.LocationY = locationY;
            this.LocationZ = locationZ;
            this.ItemType = type;
        }
        public virtual byte[] Serialize()
        {
            Packets.PacketWriter writer = new Packets.PacketWriter();
            writer.WriteUShort(this.GraphicID);
            writer.WriteUShort(this.LocationX);
            writer.WriteUShort(this.LocationY);
            writer.WriteUShort(this.LocationZ);
            return writer.ToArray();
        }
        public virtual RoomItem DeSerialize(byte[] ob)
        {
            if (ob.Length != 8) { throw new ArgumentOutOfRangeException("Stream is not 6 bytes !!"); }
            RoomItem result = null;
            Packets.PacketReader reader = new Packets.PacketReader(ob);
            ushort gid = reader.ReadUInt16();
            ushort locx = reader.ReadUInt16();
            ushort locy = reader.ReadUInt16();
            ushort locz = reader.ReadUInt16();
            reader.Close();
            result = new RoomItem(gid, RoomItemtype.NonInteractive, locx, locy, locz);
            return result;
        }
    }
}
