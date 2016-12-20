using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6805 : Room
{
public Room6805()
: base(6805, "Incantations Institute Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2107, 83, 169, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 225, 161, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 594, 35, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 497, 36, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 400, 27, 65526, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 126, 9, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2002, 313, 37, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 222, 10, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2014, 33, 35, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65502, 409, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(34915, 625, 402, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2148, 37, 170, 65522, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(34917, 278, 162, 11, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 357, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 140, 78, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 19, 98, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 421, 110, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 350, 181, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(34917, 401, 182, 65521, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 466, 224, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(34916, 275, 162, 65523, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2153, 178, 270, 40, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 179, 269, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2556, 54, 133, 16, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 257, 122, 12, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 331, 142, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 42, 132, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 205, 121, 0, 6805));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 384, 143, 12, 6805));



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
