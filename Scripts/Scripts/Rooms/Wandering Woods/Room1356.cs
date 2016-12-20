using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1356 : Room
{
public Room1356()
: base(1356, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 122, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33726, 239, 239, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 570, 131, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 367, 104, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 367, 210, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 134, 124, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 196, 227, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 208, 118, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 355, 205, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 612, 131, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 384, 166, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 99, 133, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 44, 132, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 641, 219, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 483, 133, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 275, 230, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 58, 201, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 224, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33703, 279, 127, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 260, 130, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 13, 322, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 79, 199, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 239, 148, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 325, 117, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33722, 324, 104, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 179, 216, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 382, 206, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 132, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 621, 204, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 131, 266, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 259, 216, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 251, 124, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 85, 325, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33702, 246, 157, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 285, 143, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33701, 177, 249, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 79, 211, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33725, 434, 206, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 104, 204, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 354, 144, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33707, 211, 333, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 131, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 131, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 133, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33709, 235, 219, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33708, 262, 218, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 15, 225, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 204, 242, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 216, 113, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 539, 234, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(933, 544, 264, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(940, 442, 198, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 611, 221, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(944, 481, 234, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 413, 142, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 337, 167, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 438, 115, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 420, 253, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 316, 264, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(940, 543, 328, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(935, 482, 132, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(949, 661, 128, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 177, 126, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 528, 134, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 443, 104, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 486, 138, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 518, 134, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 525, 130, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 117, 262, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 90, 219, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 24, 263, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 133, 224, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 186, 225, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 163, 259, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 462, 126, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 349, 319, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 360, 120, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 204, 192, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 200, 214, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 182, 216, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 219, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 149, 228, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 169, 287, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 180, 295, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 185, 313, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 158, 271, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 498, 204, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 510, 214, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 525, 226, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 544, 234, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 563, 240, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 578, 248, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 586, 254, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 574, 262, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 564, 274, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 565, 294, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 563, 313, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 501, 137, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 522, 133, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 542, 128, 0, 1356));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 563, 125, 0, 1356));



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
