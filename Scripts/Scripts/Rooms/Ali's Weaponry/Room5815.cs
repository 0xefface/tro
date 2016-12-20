using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5815 : Room
{
public Room5815()
: base(5815, "Ali's Weaponry")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 150, 16, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 65489, 169, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(35383, 65490, 206, 150, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 228, 49, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 434, 30, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 435, 50, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 28, 211, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 396, 195, 80, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(35483, 450, 189, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 466, 193, 30, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(35482, 199, 181, 30, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 195, 179, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 198, 202, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 334, 49, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 355, 206, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 285, 203, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 210, 150, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 318, 35, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 324, 150, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 435, 150, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 208, 147, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 323, 147, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 433, 148, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2793, 39, 171, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2803, 34, 180, 21, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 506, 264, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 122, 271, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 360, 283, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 581, 14, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 514, 19, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 601, 46, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 544, 78, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 627, 76, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 589, 101, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 607, 125, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 676, 155, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 642, 189, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 652, 223, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 603, 240, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 556, 138, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 659, 251, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 557, 233, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(1535, 509, 43, 0, 5815));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 440, 202, 0, 5815));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5810;
                case RoomExit.South: return 21851;
                case RoomExit.East:  return 5816;
                case RoomExit.West:  return 5814;
                default: return 0;
            }
        }
}
}
