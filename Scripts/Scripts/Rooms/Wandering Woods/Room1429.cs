using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1429 : Room
{
public Room1429()
: base(1429, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.UpLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 371, 225, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 457, 314, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 541, 318, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 262, 139, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 326, 318, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 604, 450, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 121, 139, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 273, 138, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 523, 352, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 23, 328, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 66, 335, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 354, 333, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 524, 138, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 628, 279, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 536, 140, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 6, 333, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 367, 333, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65534, 316, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(106, 146, 318, 0, 1429));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 66, 217, 0, 1429));



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
