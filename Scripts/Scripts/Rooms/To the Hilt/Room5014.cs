using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5014 : Room
{
public Room5014()
: base(5014, "To the Hilt")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(3, 453, 199, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 141, 5, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 38, 18, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 243, 27, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 70, 44, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 234, 53, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 146, 53, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 108, 195, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 171, 195, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 4, 143, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 18, 149, 20, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 343, 65516, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 396, 139, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 455, 121, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 366, 192, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 488, 101, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 404, 215, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 443, 81, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 365, 208, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 190, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 138, 207, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 12, 190, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 33, 190, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35463, 488, 186, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 316, 194, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 227, 6, 20, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2582, 107, 139, 65526, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 120, 156, 20, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 11, 182, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 536, 83, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 378, 212, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 45, 188, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 355, 206, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 53, 190, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 196, 192, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 83, 192, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 185, 192, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 531, 55, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 527, 73, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 619, 164, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 500, 195, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 603, 157, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 643, 48, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 650, 185, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 568, 265, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 498, 290, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 536, 265, 0, 5014));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 614, 328, 0, 5014));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2059;
                case RoomExit.South: return 5029;
                case RoomExit.East:  return 3036;
                case RoomExit.West:  return 5013;
                default: return 0;
            }
        }
}
}
