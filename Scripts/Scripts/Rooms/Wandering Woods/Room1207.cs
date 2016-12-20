using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1207 : Room
{
public Room1207()
: base(1207, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 377, 145, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 145, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 633, 142, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 42, 324, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 627, 121, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 123, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 376, 149, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 98, 227, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 65496, 148, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 161, 247, 0, 1207));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 646, 336, 0, 1207));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1201;
                case RoomExit.South: return 1213;
                case RoomExit.East:  return 1208;
                case RoomExit.West:  return 1206;
                default: return 0;
            }
        }
}
}
