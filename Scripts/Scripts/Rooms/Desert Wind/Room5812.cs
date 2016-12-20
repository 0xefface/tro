using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5812 : Room
{
public Room5812()
: base(5812, "Desert Wind")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 187, 70, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 291, 56, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 200, 78, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 271, 13, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 498, 147, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2508, 37, 49, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 447, 222, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 441, 157, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 243, 80, 14, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 138, 82, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 311, 1, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 18, 226, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1537, 127, 242, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2795, 148, 152, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2793, 188, 130, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1530, 90, 246, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1532, 117, 243, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 55, 220, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 63, 285, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 0, 261, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 14, 231, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 84, 178, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 85, 172, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 172, 232, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 464, 227, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1507, 426, 223, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 449, 233, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 479, 264, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 665, 292, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 593, 269, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 540, 242, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 469, 250, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 540, 10, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 615, 11, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 605, 34, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 584, 65, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 645, 99, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 628, 219, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 616, 71, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 638, 233, 0, 5812));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 65463, 225, 0, 5812));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21499;
                case RoomExit.South: return 5817;
                case RoomExit.East:  return 21723;
                case RoomExit.West:  return 5811;
                default: return 0;
            }
        }
}
}
