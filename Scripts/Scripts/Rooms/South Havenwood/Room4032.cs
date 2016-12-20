using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4032 : Room
{
public Room4032()
: base(4032, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 432, 107, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 629, 335, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 24, 257, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 274, 355, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 50, 118, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 122, 127, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 531, 123, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 614, 117, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 581, 125, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 23, 247, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 18, 248, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 126, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 117, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 117, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 122, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 124, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 124, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 124, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 124, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 326, 187, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 566, 193, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 565, 183, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 429, 194, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 449, 185, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 340, 197, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 266, 206, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 271, 235, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 267, 211, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 269, 220, 0, 4032));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 280, 221, 0, 4032));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4016;
                case RoomExit.South: return 4047;
                case RoomExit.East:  return 4033;
                case RoomExit.West:  return 4031;
                default: return 0;
            }
        }
}
}
