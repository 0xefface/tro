using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5085 : Room
{
public Room5085()
: base(5085, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 194, 1, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 231, 198, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 76, 209, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 604, 208, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 540, 279, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 81, 277, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 472, 199, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 444, 243, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 145, 238, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 332, 200, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 7, 200, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 87, 184, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 451, 273, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 7, 47, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 514, 179, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 338, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 586, 40, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 246, 168, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 394, 170, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 482, 20, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 82, 313, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 4, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 549, 1, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 94, 22, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 301, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 614, 307, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 21, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 177, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 99, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 502, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 367, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 207, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 531, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 257, 305, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 260, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 287, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 447, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 419, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 181, 264, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 106, 262, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 380, 242, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 614, 12, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 2, 297, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 226, 198, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 467, 281, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 65533, 35, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 132, 48, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 557, 41, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 49, 66, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 306, 220, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 320, 252, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 103, 250, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 597, 254, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 558, 234, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 253, 283, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 403, 282, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 126, 294, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 584, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 566, 306, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 505, 309, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 418, 315, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 613, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 128, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 47, 465, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 541, 262, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 219, 291, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 618, 73, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 580, 49, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 18, 19, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 80, 42, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 600, 42, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 324, 285, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 135, 328, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 418, 328, 0, 5085));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 591, 320, 0, 5085));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5070;
                case RoomExit.South: return 4010;
                case RoomExit.East:  return 5086;
                case RoomExit.West:  return 5084;
                default: return 0;
            }
        }
}
}
