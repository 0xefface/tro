using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1128 : Room
{
public Room1128()
: base(1128, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 105, 109, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 609, 122, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 339, 120, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 56, 325, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 323, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 338, 122, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 221, 59, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 66, 267, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 287, 62, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 335, 118, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 38, 287, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 144, 302, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 108, 275, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 225, 285, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 25, 282, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 219, 272, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 121, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 124, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 123, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 123, 0, 1128));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 30, 316, 0, 1128));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1121;
                case RoomExit.South: return 1136;
                case RoomExit.East:  return 1129;
                case RoomExit.West:  return 1127;
                default: return 0;
            }
        }
}
}
