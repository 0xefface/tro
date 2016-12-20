using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1183 : Room
{
public Room1183()
: base(1183, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65503, 129, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 422, 131, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 359, 132, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 622, 143, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 134, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 137, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 147, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 175, 130, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 529, 137, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 518, 273, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 489, 260, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 491, 255, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 277, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 219, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 597, 209, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 26, 255, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 105, 229, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 111, 230, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 91, 238, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 233, 230, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 230, 220, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 83, 226, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 47, 268, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65532, 254, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 265, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 258, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 452, 254, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 438, 246, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 129, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 643, 212, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 83, 337, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 568, 334, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 262, 225, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 425, 299, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 439, 252, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 145, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 137, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 129, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 136, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 136, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 136, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 137, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 145, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 132, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 133, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 135, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 135, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 70, 194, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 197, 199, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 1, 194, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 251, 254, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 165, 316, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 299, 294, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 177, 302, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 131, 241, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 120, 232, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 29, 226, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32949, 376, 260, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 103, 264, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 21, 300, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 339, 268, 0, 1183));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 254, 332, 0, 1183));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1177;
                case RoomExit.South: return 1189;
                case RoomExit.East:  return 1184;
                case RoomExit.West:  return 1182;
                default: return 0;
            }
        }
}
}
