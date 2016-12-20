using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5029 : Room
{
public Room5029()
: base(5029, "East Leinster Chapel")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(3, 357, 194, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 629, 315, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 489, 202, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 228, 112, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 179, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 82, 196, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 393, 67, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 357, 113, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 98, 189, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 105, 6, 65419, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 439, 52, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 412, 206, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 474, 206, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 146, 48, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 122, 203, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 105, 181, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 612, 2, 65514, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 346, 19, 65273, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 10, 8, 65489, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 520, 262, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 60, 8, 65419, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(32949, 516, 260, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 51, 2, 65419, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 139, 3, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 147, 10, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 65532, 92, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 70, 2, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(32949, 271, 194, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 629, 10, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 473, 186, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 484, 9, 65353, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 111, 189, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 490, 188, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 91, 9, 65379, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 620, 322, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 436, 131, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2702, 144, 70, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2528, 208, 9, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 439, 11, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2528, 374, 8, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2529, 283, 46, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(35470, 440, 68, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 147, 136, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 437, 134, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 146, 133, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 500, 200, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 633, 48, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 65497, 30, 0, 5029));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 173, 63, 0, 5029));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5014;
                case RoomExit.South: return 5044;
                case RoomExit.East:  return 3012;
                case RoomExit.West:  return 5028;
                default: return 0;
            }
        }
}
}
