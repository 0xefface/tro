using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5089 : Room
{
public Room5089()
: base(5089, "All Things Useful")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.DownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 286, 43, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 333, 50, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 312, 61, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 475, 32, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 634, 445, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 181, 170, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 543, 140, 80, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2544, 410, 188, 20, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 364, 160, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 321, 228, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 364, 175, 20, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 297, 164, 20, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2541, 397, 185, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 264, 25, 65437, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 391, 71, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 185, 218, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 718, 326, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 504, 449, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 11, 446, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 556, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 389, 70, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 335, 61, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 247, 213, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 293, 222, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 418, 223, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2244, 325, 228, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 297, 149, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 637, 330, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 637, 165, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 38, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 89, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 112, 446, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 165, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 193, 449, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 242, 449, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 267, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 316, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 343, 450, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 396, 449, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 420, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 475, 448, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 581, 445, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 31, 3, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 81, 21, 0, 5089));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 96, 246, 0, 5089));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5074;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 5088;
                default: return 0;
            }
        }
}
}
