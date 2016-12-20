using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5817 : Room
{
public Room5817()
: base(5817, "Village Green")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 531, 253, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 54, 295, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 508, 88, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 458, 139, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 520, 136, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 542, 159, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 38, 267, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 515, 107, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(34276, 623, 111, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 355, 115, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 395, 113, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 40, 110, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 65, 164, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 593, 145, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 87, 142, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 159, 159, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 588, 169, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 443, 163, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 22, 156, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 130, 174, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 48, 207, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 423, 142, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 589, 167, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 130, 148, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 90, 97, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 327, 91, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 485, 101, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 473, 103, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 332, 100, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 14, 212, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 155, 162, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 435, 147, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 516, 160, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 51, 156, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 118, 149, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 427, 163, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 560, 138, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 470, 139, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 120, 177, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 464, 141, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 513, 147, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 457, 165, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 59, 146, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 91, 169, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 386, 155, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 537, 138, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 528, 105, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(34310, 427, 103, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 415, 101, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35516, 195, 102, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(35516, 70, 102, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 583, 289, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(201, 11, 216, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 74, 146, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 57, 93, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 99, 121, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 565, 164, 0, 5817));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 191, 91, 0, 5817));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5812;
                case RoomExit.South: return 21853;
                case RoomExit.East:  return 21729;
                case RoomExit.West:  return 5816;
                default: return 0;
            }
        }
}
}
