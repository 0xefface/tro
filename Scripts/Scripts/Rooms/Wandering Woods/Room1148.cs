using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1148 : Room
{
public Room1148()
: base(1148, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 518, 154, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 541, 226, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 585, 156, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 545, 227, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 583, 159, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 94, 186, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 553, 239, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 72, 202, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 245, 104, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 479, 118, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 537, 240, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 184, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65531, 184, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 1148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 1148));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1139;
                case RoomExit.South: return 1258;
                case RoomExit.East:  return 1192;
                case RoomExit.West:  return 1147;
                default: return 0;
            }
        }
}
}
