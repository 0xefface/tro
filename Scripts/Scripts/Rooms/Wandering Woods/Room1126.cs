using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1126 : Room
{
public Room1126()
: base(1126, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 440, 103, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 509, 115, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 437, 249, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 79, 318, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 189, 144, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 145, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 437, 252, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 287, 2, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 126, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 242, 106, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 123, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 123, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 123, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 121, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 119, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 118, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 125, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 125, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 125, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 124, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 124, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 123, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 200, 162, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 93, 185, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 86, 178, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 204, 168, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 271, 134, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 269, 114, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(33002, 267, 97, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 167, 238, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 57, 241, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 182, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 30, 181, 0, 1126));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 79, 197, 0, 1126));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1119;
                case RoomExit.South: return 1134;
                case RoomExit.East:  return 1127;
                case RoomExit.West:  return 1125;
                default: return 0;
            }
        }
}
}
