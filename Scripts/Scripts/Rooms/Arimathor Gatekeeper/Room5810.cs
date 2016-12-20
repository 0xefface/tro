using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5810 : Room
{
public Room5810()
: base(5810, "Arimathor Gatekeeper")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 106, 218, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 98, 32, 65456, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2641, 629, 71, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 560, 12, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 504, 20, 65437, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65534, 35, 65456, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 15, 117, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 562, 131, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 583, 103, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 554, 100, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 613, 10, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2641, 516, 68, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 65534, 5, 65456, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 11, 294, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2582, 289, 184, 15, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 46, 279, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 415, 215, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 272, 268, 200, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 368, 60, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 190, 67, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 217, 228, 160, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 164, 227, 160, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 147, 60, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2723, 325, 219, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 73, 1, 65456, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 298, 66, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 357, 267, 200, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1536, 122, 214, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 155, 220, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 606, 113, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 51, 111, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 199, 215, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 605, 119, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 278, 225, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(34290, 363, 225, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(34355, 44, 114, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 458, 196, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2585, 184, 158, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 164, 156, 0, 5810));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 324, 226, 0, 5810));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5806;
                case RoomExit.South: return 5815;
                case RoomExit.East:  return 5811;
                case RoomExit.West:  return 5809;
                default: return 0;
            }
        }
}
}
