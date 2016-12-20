using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1430 : Room
{
public Room1430()
: base(1430, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 131, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 572, 326, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 277, 219, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 42, 132, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 604, 131, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 265, 221, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 567, 134, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 604, 127, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 134, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 176, 105, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 130, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 131, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 133, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 131, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 132, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 131, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 455, 105, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 560, 105, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 137, 111, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 492, 109, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 318, 109, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 499, 326, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 112, 113, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 517, 301, 0, 1430));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 212, 325, 0, 1430));



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
