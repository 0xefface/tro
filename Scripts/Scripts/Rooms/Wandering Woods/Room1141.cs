using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1141 : Room
{
public Room1141()
: base(1141, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 107, 111, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 568, 124, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 619, 180, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 64, 289, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 189, 317, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32871, 65518, 315, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 7, 303, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 147, 310, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 245, 104, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 160, 299, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 304, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 33, 322, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 558, 181, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 571, 190, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 434, 212, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 419, 208, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 447, 274, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 442, 258, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 393, 264, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 409, 284, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 570, 314, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 537, 299, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 588, 315, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 590, 289, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 538, 295, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 608, 206, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 567, 181, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 609, 284, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 653, 289, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 674, 263, 0, 1141));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 627, 251, 0, 1141));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1132;
                case RoomExit.South: return 1251;
                case RoomExit.East:  return 1142;
                case RoomExit.West:  return 1140;
                default: return 0;
            }
        }
}
}
