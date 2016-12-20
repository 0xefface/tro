using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1509 : Room
{
public Room1509()
: base(1509, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 38, 127, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 528, 121, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 288, 132, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 143, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 154, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 339, 140, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 408, 147, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 134, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 33, 207, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 271, 247, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 478, 322, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 616, 278, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 18, 208, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 50, 178, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 449, 367, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 478, 334, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 327, 258, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 332, 198, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 286, 313, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 271, 185, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 588, 278, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 556, 292, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 153, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 295, 254, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 25, 182, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 104, 143, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 158, 181, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 153, 175, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 123, 179, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 135, 168, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 143, 185, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 77, 282, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 242, 297, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 202, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 51, 211, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 293, 196, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 420, 232, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 243, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 602, 298, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 299, 260, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 146, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 142, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 218, 138, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 139, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 138, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 153, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 138, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 132, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 140, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 137, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 142, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 144, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 146, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 136, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 108, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 84, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 388, 227, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 409, 230, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 338, 179, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 318, 183, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 394, 203, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 401, 214, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 402, 201, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 268, 179, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(32998, 7, 222, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 613, 270, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 128, 195, 0, 1509));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 112, 194, 0, 1509));



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
