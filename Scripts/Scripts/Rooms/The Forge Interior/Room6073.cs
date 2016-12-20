using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6073 : Room
{
public Room6073()
: base(6073, "The Forge Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 280, 23, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 381, 15, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2221, 580, 171, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 89, 23, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2014, 15, 97, 50, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 494, 24, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 427, 179, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(34887, 427, 180, 2, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 431, 180, 58, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 434, 180, 31, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 116, 89, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 13, 305, 200, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 533, 280, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 52, 269, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2120, 310, 236, 58, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(34887, 530, 281, 2, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 65, 270, 2, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 540, 281, 34, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 59, 270, 34, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 304, 235, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 256, 142, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 373, 68, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 490, 67, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 185, 23, 0, 6073));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 33, 152, 0, 6073));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
