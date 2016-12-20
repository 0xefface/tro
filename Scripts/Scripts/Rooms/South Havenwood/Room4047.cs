using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4047 : Room
{
public Room4047()
: base(4047, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 562, 248, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 506, 121, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 41, 119, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 121, 251, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 155, 254, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 109, 255, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 84, 144, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 138, 253, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 553, 240, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 585, 238, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 69, 143, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 93, 147, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 563, 241, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 121, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 122, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 122, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 55, 119, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 120, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 119, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 283, 104, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 276, 110, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 275, 129, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 275, 153, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 286, 194, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 291, 234, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 311, 229, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 289, 175, 0, 4047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 277, 134, 0, 4047));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4032;
                case RoomExit.South: return 1202;
                case RoomExit.East:  return 4048;
                case RoomExit.West:  return 4046;
                default: return 0;
            }
        }
}
}
