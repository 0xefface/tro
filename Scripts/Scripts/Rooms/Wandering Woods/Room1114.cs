using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1114 : Room
{
public Room1114()
: base(1114, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(176, 72, 103, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 110, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 484, 110, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 506, 308, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 145, 140, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 549, 309, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 499, 310, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 309, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 137, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 282, 103, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 292, 47, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 144, 143, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 543, 334, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 636, 323, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 456, 323, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 369, 104, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 320, 192, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 421, 192, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 364, 215, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 352, 223, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 375, 224, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 332, 224, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 363, 107, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 359, 134, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 373, 171, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 383, 169, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 205, 213, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 490, 209, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 581, 212, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 477, 210, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 279, 248, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 392, 244, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 150, 213, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 72, 249, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 176, 300, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 543, 246, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 290, 216, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 37, 194, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 42, 188, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 96, 216, 0, 1114));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 11, 210, 0, 1114));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1104;
                case RoomExit.South: return 1121;
                case RoomExit.East:  return 1115;
                case RoomExit.West:  return 1113;
                default: return 0;
            }
        }
}
}
