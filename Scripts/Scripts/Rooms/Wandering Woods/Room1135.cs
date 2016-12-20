using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1135 : Room
{
public Room1135()
: base(1135, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 608, 312, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 535, 274, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 650, 277, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 248, 103, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65507, 104, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 75, 175, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 95, 183, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 624, 319, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 541, 273, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 214, 39, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 526, 112, 0, 1135));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 177, 103, 0, 1135));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1127;
                case RoomExit.South: return 1144;
                case RoomExit.East:  return 1136;
                case RoomExit.West:  return 1134;
                default: return 0;
            }
        }
}
}
