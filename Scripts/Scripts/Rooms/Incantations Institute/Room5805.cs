using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5805 : Room
{
public Room5805()
: base(5805, "Incantations Institute")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 461, 143, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 39, 45, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2522, 441, 156, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 183, 26, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 197, 64, 50, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 425, 147, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 473, 221, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 548, 43, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 488, 213, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 239, 199, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 89, 207, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 200, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 51, 156, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 397, 221, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 309, 212, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 278, 206, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 80, 55, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 34, 210, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 380, 163, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 572, 42, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 282, 177, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1544, 61, 222, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 50, 162, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 281, 183, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 399, 162, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2701, 180, 210, 95, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 172, 68, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 636, 107, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 568, 72, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 373, 220, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 337, 230, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 387, 238, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 355, 248, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 372, 230, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 453, 111, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 65524, 297, 0, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 505, 94, 65486, 5805));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 618, 297, 0, 5805));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5802;
                case RoomExit.South: return 5809;
                case RoomExit.East:  return 5806;
                case RoomExit.West:  return 5804;
                default: return 0;
            }
        }
}
}
