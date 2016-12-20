using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5811 : Room
{
public Room5811()
: base(5811, "Desert Rose")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 143, 78, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 200, 79, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 543, 75, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 325, 78, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 450, 78, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 192, 243, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 30, 270, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2808, 533, 151, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 114, 240, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2799, 545, 151, 23, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 157, 91, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2633, 272, 91, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2634, 531, 89, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2633, 405, 90, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 145, 121, 40, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 425, 122, 40, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 286, 122, 40, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 541, 122, 40, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 299, 188, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 299, 192, 12, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 182, 193, 13, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 180, 188, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 70, 235, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 242, 230, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(32814, 357, 233, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 45, 224, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65509, 238, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(32828, 348, 238, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 567, 229, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 520, 264, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 648, 230, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 560, 241, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 694, 203, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 732, 182, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(35371, 716, 26, 65435, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 380, 249, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 611, 6, 65438, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 617, 20, 65424, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34306, 623, 173, 65476, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1537, 623, 49, 4, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 571, 233, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2511, 638, 60, 65499, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 550, 227, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1536, 11, 203, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65478, 59, 65486, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34304, 48, 193, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 310, 290, 65424, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 70, 71, 65449, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 310, 290, 65424, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1537, 15, 163, 4, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(34304, 36, 35, 65486, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 65526, 43, 0, 5811));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 264, 241, 0, 5811));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21498;
                case RoomExit.South: return 5816;
                case RoomExit.East:  return 5812;
                case RoomExit.West:  return 5810;
                default: return 0;
            }
        }
}
}
