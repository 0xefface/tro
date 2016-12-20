using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1202 : Room
{
public Room1202()
: base(1202, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 518, 154, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 519, 204, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 585, 156, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 560, 270, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 583, 159, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 94, 186, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 568, 267, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 72, 202, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 245, 104, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 479, 118, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 515, 215, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 184, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65531, 184, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 50, 204, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 320, 207, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 203, 209, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 385, 216, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 479, 216, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 591, 183, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 455, 214, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 527, 262, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 582, 266, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 330, 263, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 315, 261, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 315, 106, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 310, 129, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 310, 106, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 303, 150, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 316, 150, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 308, 168, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 296, 175, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 267, 248, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 375, 251, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 129, 241, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 534, 253, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 444, 257, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 450, 246, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 21, 240, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 616, 252, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(32982, 566, 220, 0, 1202));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 570, 256, 0, 1202));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4047;
                case RoomExit.South: return 1208;
                case RoomExit.East:  return 1203;
                case RoomExit.West:  return 1201;
                default: return 0;
            }
        }
}
}
