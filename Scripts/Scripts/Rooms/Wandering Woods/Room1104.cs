using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1104 : Room
{
public Room1104()
: base(1104, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 87, 110, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 66, 254, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 55, 247, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 470, 171, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 439, 170, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 411, 174, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 370, 175, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 375, 201, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 391, 198, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 429, 201, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 259, 106, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 542, 105, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 176, 103, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 365, 175, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 374, 185, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 509, 171, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 574, 172, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 310, 202, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 321, 199, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 316, 243, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 345, 234, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 503, 197, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 492, 201, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 171, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 549, 199, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 615, 199, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 391, 198, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 519, 171, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 571, 172, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 590, 197, 0, 1104));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 610, 171, 0, 1104));

base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22034;
                case RoomExit.South: return 1109;
                case RoomExit.East:  return 1105;
                case RoomExit.West:  return 22041;
                default: return 0;
            }
        }
}
}
