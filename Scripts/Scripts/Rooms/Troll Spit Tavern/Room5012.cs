using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5012 : Room
{
public Room5012()
: base(5012, "Troll Spit Tavern")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 566, 4, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 501, 28, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 634, 199, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 412, 162, 150, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 258, 18, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 75, 162, 20, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(35381, 707, 321, 200, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 32, 145, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 329, 171, 150, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 498, 172, 150, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 414, 244, 200, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2621, 898, 162, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 65475, 156, 20, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2632, 326, 39, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2632, 496, 39, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2635, 414, 310, 250, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 317, 27, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 470, 200, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2699, 264, 129, 25, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2708, 253, 113, 50, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 65401, 14, 65437, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 56, 233, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 516, 200, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 302, 206, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 565, 180, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 588, 180, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(35482, 47, 208, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 64, 205, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 410, 168, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 573, 187, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 36, 24, 65496, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 10, 219, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 105, 222, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 315, 115, 65486, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 508, 163, 0, 5012));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 28, 31, 65496, 5012));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2057;
                case RoomExit.South: return 5027;
                case RoomExit.East:  return 5013;
                case RoomExit.West:  return 5011;
                default: return 0;
            }
        }
}
}
