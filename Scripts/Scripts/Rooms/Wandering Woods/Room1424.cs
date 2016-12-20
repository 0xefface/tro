using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1424 : Room
{
public Room1424()
: base(1424, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.UpLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(114, 457, 314, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 541, 318, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 132, 183, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 365, 326, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 138, 181, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 604, 450, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 628, 279, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 524, 138, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 320, 330, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 367, 333, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 121, 140, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 273, 138, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 154, 326, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 86, 382, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 407, 322, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 19, 324, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65533, 328, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 262, 139, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 536, 140, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 63, 233, 0, 1424));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 36, 313, 0, 1424));



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
