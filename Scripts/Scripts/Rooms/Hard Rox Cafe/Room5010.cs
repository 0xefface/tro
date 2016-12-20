using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5010 : Room
{
public Room5010()
: base(5010, "Hard Rox Cafe")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 174, 58, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 431, 58, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 538, 57, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 442, 102, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 558, 44, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 500, 108, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 564, 74, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 46, 118, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 103, 45, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 344, 41, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 204, 73, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 333, 75, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 98, 79, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 275, 44, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 466, 69, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 278, 104, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 158, 116, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 678, 118, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 148, 136, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 262, 134, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 398, 132, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 609, 152, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 527, 148, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 9, 155, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 167, 166, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 283, 167, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 429, 168, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 229, 191, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 370, 187, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 491, 197, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 563, 190, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 324, 182, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 83, 172, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32968, 580, 165, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 43, 105, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 607, 74, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 147, 67, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(138, 63, 164, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(133, 32, 109, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(139, 572, 144, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(138, 603, 66, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32907, 45, 183, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 73, 106, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 601, 178, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(132, 629, 140, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32900, 18, 132, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 627, 102, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32968, 161, 66, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(2957, 125, 237, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(35726, 503, 250, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 107, 95, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(134, 510, 73, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 83, 174, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 41, 105, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 488, 75, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 177, 73, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 610, 77, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 535, 153, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 211, 62, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 54, 107, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 646, 145, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 615, 103, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 63, 90, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 568, 175, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 599, 180, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 127, 62, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 544, 167, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 70, 173, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 585, 155, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 110, 79, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 14, 142, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 580, 81, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 11, 184, 0, 5010));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 532, 77, 0, 5010));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2055;
                case RoomExit.South: return 5025;
                case RoomExit.East:  return 5011;
                case RoomExit.West:  return 5009;
                default: return 0;
            }
        }
}
}
