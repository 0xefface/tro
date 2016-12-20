using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5809 : Room
{
public Room5809()
: base(5809, "Tackle Treasury")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 40, 31, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 133, 46, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 88, 53, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 78, 55, 10, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 170, 57, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 276, 27, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 285, 223, 150, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 136, 208, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 371, 190, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 194, 209, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 417, 202, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 501, 200, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 471, 137, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 97, 211, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 379, 3, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 449, 151, 100, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 485, 31, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 57, 182, 65516, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 81, 137, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 389, 201, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 244, 167, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 496, 155, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 92, 157, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 219, 149, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2792, 158, 97, 65526, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2805, 146, 104, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(1588, 156, 198, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(34356, 626, 45, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 24, 195, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(34355, 90, 198, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 65473, 183, 50, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2622, 45, 129, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 65527, 124, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 38, 304, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 169, 215, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 160, 212, 0, 5809));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 435, 188, 0, 5809));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5805;
                case RoomExit.South: return 5814;
                case RoomExit.East:  return 5810;
                case RoomExit.West:  return 5808;
                default: return 0;
            }
        }
}
}
