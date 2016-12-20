using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Rooms
{
    public interface IRoomEntity
    {
        ushort GraphicID { get; set; }
        ushort LocationX { get; set; }
        ushort LocationY { get; set; }
        ushort LocationZ { get; set; }
        int RoomID { get; set; }
        void Dispose();
        RoomDecoration UnSerialize(byte[] stream, ushort toRoomID);
        byte[] Serialize();
    }
}
