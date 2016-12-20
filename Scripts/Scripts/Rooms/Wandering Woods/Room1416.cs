using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1416 : Room
{
public Room1416()
: base(1416, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(114, 487, 321, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 541, 318, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 128, 212, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 174, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 298, 172, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 604, 450, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 178, 213, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 253, 211, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 414, 213, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 565, 212, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 121, 140, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 273, 138, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(191, 51, 239, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 86, 382, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 11, 329, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 283, 175, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 318, 177, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 109, 137, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 266, 329, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(107, 378, 319, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 524, 138, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 628, 279, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 262, 138, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 519, 138, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 23, 288, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 65523, 297, 0, 1416));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 59, 217, 0, 1416));



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
