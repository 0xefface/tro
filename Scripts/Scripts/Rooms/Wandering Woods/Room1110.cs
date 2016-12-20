using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1110 : Room
{
public Room1110()
: base(1110, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 312, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 112, 184, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 206, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 129, 205, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 554, 264, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 108, 185, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 639, 56, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 169, 207, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 419, 291, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 134, 180, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 323, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 502, 307, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 475, 110, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 458, 316, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 322, 282, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 452, 267, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 596, 314, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 303, 269, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 312, 256, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 623, 289, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 386, 271, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 350, 249, 0, 1110));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 459, 251, 0, 1110));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1105;
                case RoomExit.South: return 1116;
                case RoomExit.East:  return 1111;
                case RoomExit.West:  return 1109;
                default: return 0;
            }
        }
}
}
