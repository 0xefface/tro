using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1124 : Room
{
public Room1124()
: base(1124, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 125, 115, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 370, 226, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 369, 240, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 367, 230, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 463, 1, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 116, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 117, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 118, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 117, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 118, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 119, 0, 1124));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 118, 0, 1124));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1117;
                case RoomExit.South: return 1131;
                case RoomExit.East:  return 1174;
                case RoomExit.West:  return 1123;
                default: return 0;
            }
        }
}
}
