using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1383 : Room
{
public Room1383()
: base(1383, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 551, 135, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 125, 140, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 383, 144, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 584, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 179, 313, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 334, 249, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 229, 249, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 320, 252, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 156, 222, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 431, 221, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 134, 119, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 21, 218, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 79, 217, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 49, 209, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 62, 206, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 371, 231, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 207, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 24, 217, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 160, 230, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 176, 242, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 258, 251, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 225, 235, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 266, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 312, 246, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 282, 265, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 450, 229, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 428, 216, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 285, 232, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 591, 331, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 165, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 138, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 140, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 144, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 145, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 194, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 69, 194, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 135, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 134, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 133, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 140, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 139, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 206, 117, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 243, 137, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 332, 248, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 231, 204, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 200, 243, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 117, 249, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 127, 245, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 136, 233, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 146, 282, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 259, 313, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 125, 276, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 179, 299, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 344, 308, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 325, 319, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 518, 252, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 615, 249, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 578, 304, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 565, 283, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 208, 297, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 228, 277, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 177, 250, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 218, 254, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 244, 147, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 212, 133, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 260, 219, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 441, 245, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 398, 300, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 628, 301, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 203, 118, 0, 1383));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 651, 316, 0, 1383));



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
