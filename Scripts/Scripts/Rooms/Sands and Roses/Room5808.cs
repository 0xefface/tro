using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5808 : Room
{
public Room5808()
: base(5808, "Sands and Roses")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 52, 37, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 134, 50, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 105, 61, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 102, 48, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 177, 59, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 275, 28, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 310, 60, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 473, 208, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2541, 203, 171, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 71, 148, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 159, 159, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 214, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 6, 194, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 478, 208, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 468, 67, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 442, 146, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 562, 191, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 217, 181, 21, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 70, 148, 4, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 159, 160, 4, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 442, 147, 4, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 411, 9, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 516, 39, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 390, 3, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(35467, 538, 118, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 125, 265, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 16, 200, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1507, 46, 201, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 46, 201, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 42, 197, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1545, 170, 222, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 153, 228, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 496, 209, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 532, 193, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 425, 189, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 455, 199, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 0, 259, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 18, 215, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 40, 236, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 16, 32, 65408, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 34, 11, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 310, 290, 65408, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 44, 33, 65447, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 36, 35, 65485, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 42, 34, 65521, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 620, 7, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 632, 32, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 112, 229, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 586, 180, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 567, 274, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 555, 248, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 310, 290, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 516, 243, 0, 5808));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 391, 47, 0, 5808));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5804;
                case RoomExit.South: return 5813;
                case RoomExit.East:  return 5809;
                case RoomExit.West:  return 5807;
                default: return 0;
            }
        }
}
}
