using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1476 : Room
{
public Room1476()
: base(1476, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 97, 125, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 283, 130, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 421, 122, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 494, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 127, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 564, 128, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 375, 142, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 292, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 224, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 160, 239, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 313, 251, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 342, 257, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 68, 205, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 363, 238, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 67, 207, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 435, 220, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 642, 325, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 326, 235, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 329, 246, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 81, 321, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 154, 237, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 305, 249, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 327, 259, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 374, 255, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 357, 236, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 424, 230, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 622, 137, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 585, 245, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 64, 213, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 72, 199, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 124, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 124, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 133, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 142, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 141, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 140, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 143, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 139, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 343, 236, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 241, 189, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 228, 253, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 369, 185, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 457, 188, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(33706, 595, 128, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(33722, 672, 104, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(205, 609, 127, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 562, 179, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(218, 586, 146, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 118, 316, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 600, 129, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 589, 158, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 577, 184, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 206, 260, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 258, 264, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 309, 220, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 422, 217, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 489, 178, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 503, 219, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 480, 241, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 606, 120, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 607, 123, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 235, 325, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 164, 324, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 65517, 262, 0, 1476));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65519, 268, 0, 1476));



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
