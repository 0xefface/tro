using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1217 : Room
{
public Room1217()
: base(1217, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 523, 111, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 151, 112, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 34, 315, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 30, 162, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 304, 105, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 467, 325, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 239, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 601, 240, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 325, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 561, 325, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 7, 163, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 246, 107, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 491, 111, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 340, 28, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 135, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 5, 161, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 82, 135, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 66, 136, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 136, 0, 1217));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 136, 0, 1217));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1211;
                case RoomExit.South: return 1223;
                case RoomExit.East:  return 4114;
                case RoomExit.West:  return 1216;
                default: return 0;
            }
        }
}
}
