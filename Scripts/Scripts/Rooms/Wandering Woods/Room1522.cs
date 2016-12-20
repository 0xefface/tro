using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1522 : Room
{
public Room1522()
: base(1522, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65502, 119, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 581, 118, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 369, 124, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 75, 128, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 581, 146, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 319, 135, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 430, 137, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 351, 137, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 389, 149, 20, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 268, 136, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 484, 142, 20, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 528, 226, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 37, 280, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 135, 237, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 264, 217, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 633, 327, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 165, 221, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 116, 237, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 176, 224, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 227, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 389, 183, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 537, 109, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 259, 221, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 381, 167, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 374, 176, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 535, 79, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 125, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 29, 125, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 49, 128, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 128, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 136, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 135, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 136, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 136, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 137, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 136, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 385, 127, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 127, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 122, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 121, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 145, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 145, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 145, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 145, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 37, 177, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 161, 163, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 170, 162, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 220, 107, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 221, 137, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 214, 122, 0, 1522));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65530, 276, 0, 1522));


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
