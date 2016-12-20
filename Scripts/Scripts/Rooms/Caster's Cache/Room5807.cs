using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5807 : Room
{
public Room5807()
: base(5807, "Caster's Cache")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 155, 16, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 381, 45, 50, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 211, 155, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 610, 121, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 55, 65535, 65437, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 490, 206, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 589, 209, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(35483, 145, 154, 65506, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 165, 166, 20, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 496, 149, 65506, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 555, 173, 20, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 536, 205, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 379, 168, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 128, 44, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2621, 699, 121, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 105, 164, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 263, 194, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 282, 185, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 568, 126, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 256, 48, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 638, 61, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 210, 191, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 143, 181, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1523, 410, 187, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 37, 14, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 21, 41, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 75, 68, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 65519, 104, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 38, 297, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 207, 299, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 333, 290, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 376, 312, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 133, 179, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 425, 186, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 211, 149, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(1545, 14, 324, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 204, 38, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 210, 41, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 232, 27, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2517, 327, 9, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 131, 173, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(34365, 608, 306, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2704, 377, 132, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(2708, 367, 76, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 253, 212, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 610, 191, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 533, 216, 0, 5807));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 533, 216, 0, 5807));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5803;
                case RoomExit.South: return 21676;
                case RoomExit.East:  return 5808;
                case RoomExit.West:  return 21670;
                default: return 0;
            }
        }
}
}
