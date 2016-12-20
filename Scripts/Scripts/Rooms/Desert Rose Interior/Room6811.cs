using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6811 : Room
{
public Room6811()
: base(6811, "Desert Rose Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 93, 113, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 468, 343, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 208, 223, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 56, 238, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2136, 1, 239, 45, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 469, 344, 63, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2136, 150, 224, 45, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(34886, 330, 206, 2, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 609, 117, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(34886, 331, 205, 64, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 330, 206, 33, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 324, 84, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 205, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 233, 143, 17, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 424, 144, 17, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 197, 142, 0, 6811));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 389, 143, 0, 6811));



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
