using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5058 : Room
{
public Room5058()
: base(5058, "Heroic Habits")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2749, 65376, 9, 65437, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2749, 218, 6, 65437, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 55, 297, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 705, 334, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 705, 219, 20, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 60, 110, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 484, 192, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 6, 80, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 65, 294, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 439, 242, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 579, 304, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 486, 199, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 249, 381, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 571, 303, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 587, 192, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 439, 248, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 417, 240, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 591, 309, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 533, 185, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 366, 9, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 464, 13, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 581, 13, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 518, 18, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2701, 272, 176, 109, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 403, 20, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 499, 26, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 623, 28, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 602, 190, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 304, 2, 65436, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 11, 122, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 61, 293, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 501, 125, 0, 5058));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 501, 122, 0, 5058));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5043;
                case RoomExit.South: return 5073;
                case RoomExit.East:  return 5059;
                case RoomExit.West:  return 5057;
                default: return 0;
            }
        }
}
}
