using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5816 : Room
{
public Room5816()
: base(5816, "Arimathor Auctions")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 367, 44, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 454, 71, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 465, 58, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2515, 280, 20, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 176, 42, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2515, 569, 38, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 165, 55, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 158, 38, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 381, 162, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 522, 203, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 236, 184, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2556, 253, 157, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2556, 539, 176, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 382, 156, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 411, 76, 30, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2627, 100, 57, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 303, 207, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 348, 202, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2627, 381, 73, 18, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 348, 213, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 450, 74, 8, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 306, 79, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 577, 218, 99, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 645, 161, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 209, 216, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 611, 233, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 143, 209, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 625, 224, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 644, 174, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 669, 134, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 668, 91, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 142, 209, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 305, 199, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 257, 204, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 207, 64, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 362, 211, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 519, 77, 13, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 601, 51, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 124, 280, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 587, 205, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 353, 245, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 611, 231, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 291, 271, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 513, 263, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 550, 223, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 310, 216, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 260, 213, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 232, 216, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 479, 179, 99, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 109, 192, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 221, 213, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 508, 226, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 316, 209, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 410, 216, 0, 5816));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 515, 245, 0, 5816));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5811;
                case RoomExit.South: return 21852;
                case RoomExit.East:  return 5817;
                case RoomExit.West:  return 5815;
                default: return 0;
            }
        }
}
}
