using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1667 : Room
{
public Room1667()
: base(1667, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 208, 117, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 390, 128, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 132, 118, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 534, 142, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 596, 149, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 214, 132, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 335, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 24, 157, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 414, 136, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 103, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 485, 136, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 570, 133, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 165, 135, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 366, 189, 65535, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 361, 188, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 364, 187, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 255, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 139, 195, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 335, 244, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 35, 215, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 123, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 216, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 567, 294, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 99, 216, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 31, 147, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 543, 292, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 361, 179, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 421, 193, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 418, 256, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 438, 270, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 355, 192, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 330, 202, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 248, 226, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 165, 221, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 299, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 87, 229, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 138, 201, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 41, 207, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 64, 216, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 226, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 597, 291, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 526, 282, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 0, 115, 381, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 0, 156, 28, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 565, 292, 65516, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 621, 149, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 573, 150, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 141, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 424, 136, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 228, 98, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 134, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 135, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 325, 185, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 333, 190, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 277, 207, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 408, 256, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 136, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 138, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 234, 130, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 134, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 140, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 143, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 139, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 232, 86, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 148, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 248, 197, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 146, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 238, 205, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 291, 110, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 268, 127, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(33000, 261, 127, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 232, 151, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 228, 145, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 184, 193, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 183, 182, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 187, 173, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 194, 166, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 198, 177, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 192, 184, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 242, 215, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 232, 209, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 261, 254, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 291, 238, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 351, 254, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 337, 242, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 318, 232, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 215, 314, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 247, 204, 0, 1667));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 652, 320, 0, 1667));



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
