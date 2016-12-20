using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1447 : Room
{
public Room1447()
: base(1447, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 119, 116, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 231, 324, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 188, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 191, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 160, 190, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 359, 103, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 531, 113, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 110, 122, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 593, 124, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 209, 113, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 190, 325, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 63, 112, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 265, 319, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 98, 322, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 4, 119, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 110, 187, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 46, 178, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 80, 183, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 121, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 121, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 124, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 124, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 124, 0, 1447));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 124, 0, 1447));


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
