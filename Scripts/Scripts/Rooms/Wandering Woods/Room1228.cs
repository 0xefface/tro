using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1228 : Room
{
public Room1228()
: base(1228, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 202, 105, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 6, 103, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 362, 113, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 188, 170, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 571, 244, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 578, 244, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 166, 170, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 176, 166, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 585, 116, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 50, 112, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 627, 129, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 355, 240, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 611, 315, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 583, 241, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 609, 161, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 624, 302, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 130, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 130, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 32, 204, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 118, 205, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 222, 217, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 234, 205, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 282, 222, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 292, 262, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 296, 222, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 324, 267, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 299, 222, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 426, 242, 0, 1228));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 17, 237, 0, 1228));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1222;
                case RoomExit.South: return 1234;
                case RoomExit.East:  return 1229;
                case RoomExit.West:  return 1227;
                default: return 0;
            }
        }
}
}
