using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1408 : Room
{
public Room1408()
: base(1408, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 116, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 415, 262, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 416, 275, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 102, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 413, 282, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 172, 192, 0, 1408));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 381, 109, 0, 1408));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
