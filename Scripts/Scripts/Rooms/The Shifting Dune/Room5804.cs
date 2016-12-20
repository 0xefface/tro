using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5804 : Room
{
public Room5804()
: base(5804, "The Shifting Dune")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 560, 48, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35379, 278, 224, 138, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 202, 218, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 512, 115, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35528, 514, 216, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 129, 171, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 207, 118, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 182, 46, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35527, 514, 164, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 230, 223, 107, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 513, 244, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 131, 80, 65499, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 129, 50, 65368, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 415, 169, 1, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 452, 222, 138, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 514, 111, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35376, 531, 71, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 229, 216, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 445, 55, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 364, 60, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 206, 164, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 240, 82, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 285, 56, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 399, 197, 1, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 202, 232, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 513, 165, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 232, 218, 50, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 515, 204, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 659, 0, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 513, 215, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 600, 50, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(35379, 359, 220, 138, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 566, 157, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 591, 175, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1530, 10, 48, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 500, 220, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 160, 206, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 188, 213, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 231, 220, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 458, 223, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 19, 52, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 554, 220, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 40, 48, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 71, 20, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 589, 43, 65386, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 12, 297, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 579, 297, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 554, 220, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 474, 234, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 624, 206, 0, 5804));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 457, 234, 0, 5804));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5801;
                case RoomExit.South: return 5808;
                case RoomExit.East:  return 5805;
                case RoomExit.West:  return 5803;
                default: return 0;
            }
        }
}
}
