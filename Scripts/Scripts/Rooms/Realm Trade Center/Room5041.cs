using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5041 : Room
{
public Room5041()
: base(5041, "Realm Trade Center")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.UpDown;
this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 74, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 305, 99, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 354, 92, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 407, 73, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 11, 229, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 637, 345, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 444, 248, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 7, 239, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 474, 139, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 592, 148, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 13, 247, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 273, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 443, 256, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 537, 303, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(32814, 623, 107, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 610, 166, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 382, 256, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 448, 250, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(35381, 229, 108, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 246, 233, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 327, 220, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 95, 200, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 96, 78, 13, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 263, 206, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 344, 193, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 95, 194, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 96, 78, 19, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(35381, 337, 108, 16, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 404, 95, 65342, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 253, 264, 0, 5041));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 561, 284, 0, 5041));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5026;
                case RoomExit.South: return 5056;
                case RoomExit.East:  return 5042;
                case RoomExit.West:  return 5040;
                default: return 0;
            }
        }
}
}
