using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5801 : Room
{
public Room5801()
: base(5801, "Anything and Everything")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 358, 70, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 310, 77, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 232, 50, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 578, 227, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 516, 73, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 278, 78, 10, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 406, 134, 48, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2852, 503, 74, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 549, 235, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 448, 176, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 618, 226, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 590, 253, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 71, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 569, 55, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2853, 485, 76, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2852, 617, 57, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 378, 236, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 380, 181, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 381, 131, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 408, 236, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 406, 182, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 405, 131, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 179, 160, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 179, 106, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 183, 208, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 473, 194, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1507, 178, 210, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34275, 209, 215, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 178, 168, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1506, 190, 221, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 299, 252, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 229, 223, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 205, 214, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 135, 212, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 243, 178, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 232, 159, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 267, 234, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(2244, 426, 246, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 7, 153, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 281, 233, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 548, 264, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 202, 53, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34306, 139, 221, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 69, 12, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1537, 22, 77, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 32, 67, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 43, 97, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 714, 172, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 383, 266, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 503, 248, 0, 5801));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 387, 244, 0, 5801));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21448;
                case RoomExit.South: return 5804;
                case RoomExit.East:  return 5802;
                case RoomExit.West:  return 5800;
                default: return 0;
            }
        }
}
}
