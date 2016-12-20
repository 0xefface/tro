using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Rooms
{
    public class RoomDecoration
    {
        public ushort GraphicID { get; set; }
        public ushort LocationX { get; set; }
        public ushort LocationY { get; set; }
        public ushort LocationZ { get; set; }
        public uint RoomID { get; set; }
        public RoomDecoration UnSerialize(byte[] stream, ushort toRoomID)
        {
            // If we do not have 8 bytes, then we are in trouble
            // So if not the correct amount of bytes, or a bad roomid return nothing.
            if (stream.Length != 8 || toRoomID < 0) { return null; }
            // 3 sets of 2 bytes, and a room ID
            var room = this as RoomDecoration;
            room.GraphicID = BitConverter.ToUInt16(stream, 0);
            room.LocationX = BitConverter.ToUInt16(stream, 2);
            room.LocationY = BitConverter.ToUInt16(stream, 4);
            room.LocationZ = BitConverter.ToUInt16(stream, 6);
            room.RoomID = toRoomID;
            return room;
        }
        public static RoomDecoration FromCode(ushort graphicID, ushort X, ushort Y, ushort Z, uint forRoom)
        {
            RoomDecoration reply = new RoomDecoration(graphicID);
            reply.LocationX = X;
            reply.LocationY = Y;
            reply.LocationZ = Z;
            reply.RoomID = forRoom;
            return reply;
        }
        public virtual byte[] Serialize()
        {
            // Build the small list, 3 ushorts
            List<byte> buffer = new List<byte>();
            buffer.AddRange(BitConverter.GetBytes(this.GraphicID)); // Graphic Id First
            buffer.AddRange(BitConverter.GetBytes(this.LocationX));
            buffer.AddRange(BitConverter.GetBytes(this.LocationY));
            buffer.AddRange(BitConverter.GetBytes(this.LocationZ));
            return buffer.ToArray();
        }
        public RoomDecoration(ushort graphicID)
        {
            this.GraphicID = graphicID;
        }
        public void SetLocation(uint inRoom, ushort X, ushort Y, ushort Z)
        {
            this.RoomID = inRoom;
            this.LocationX = X;
            this.LocationY = Y;
            this.LocationZ = Z;
        }
    }
}
