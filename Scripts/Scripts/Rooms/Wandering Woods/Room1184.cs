using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1184 : Room
{
public Room1184()
: base(1184, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65495, 129, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 619, 134, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 437, 129, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 437, 136, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 142, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 153, 137, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 10, 143, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 301, 138, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 137, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 214, 137, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 501, 135, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 98, 133, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 359, 262, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 482, 223, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 43, 209, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 433, 221, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 518, 222, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 195, 248, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 336, 255, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 177, 126, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 215, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 59, 213, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 251, 260, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 368, 141, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 211, 265, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 288, 267, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 289, 259, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 267, 251, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 303, 245, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 183, 246, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 215, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 39, 204, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 450, 229, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 218, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 473, 214, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 512, 220, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 232, 241, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 81, 213, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 462, 215, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 223, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 237, 268, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 411, 230, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 507, 231, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 512, 230, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 136, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 135, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 135, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 136, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 234, 135, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 132, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 99, 132, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 139, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 340, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 383, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 135, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 140, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 141, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 141, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 141, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 141, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 120, 224, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 97, 224, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 138, 181, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 79, 212, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 239, 129, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 254, 111, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 223, 146, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 229, 146, 0, 1184));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 151, 197, 0, 1184));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1178;
                case RoomExit.South: return 1190;
                case RoomExit.East:  return 1185;
                case RoomExit.West:  return 1183;
                default: return 0;
            }
        }
}
}
