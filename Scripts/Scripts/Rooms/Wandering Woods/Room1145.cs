using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1145 : Room
{
public Room1145()
: base(1145, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(176, 314, 103, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65532, 104, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 65496, 102, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 1, 118, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 547, 123, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 122, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(33009, 307, 11, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 120, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 492, 194, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 491, 193, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(33013, 235, 7, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 165, 103, 0, 1145));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 138, 310, 0, 1145));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1136;
                case RoomExit.South: return 1255;
                case RoomExit.East:  return 1146;
                case RoomExit.West:  return 1144;
                default: return 0;
            }
        }
}
}
