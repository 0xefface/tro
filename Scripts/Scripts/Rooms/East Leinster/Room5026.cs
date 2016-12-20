using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5026 : Room
{
public Room5026()
: base(5026, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(35517, 789, 97, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2958, 648, 124, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 611, 118, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35517, 293, 97, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 146, 103, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 570, 268, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 641, 125, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 80, 93, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 192, 85, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 97, 117, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 225, 107, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 36, 116, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 212, 120, 2, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 87, 12, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 585, 31, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 522, 36, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 296, 92, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 492, 90, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 242, 46, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 71, 313, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 27, 79, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 596, 99, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 596, 306, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 612, 313, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 616, 88, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 535, 79, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 24, 305, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 33, 109, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 95, 114, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 216, 102, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 36, 324, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 600, 320, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 575, 242, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 35, 226, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 284, 253, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 111, 330, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 534, 322, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 159, 118, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 215, 328, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 497, 328, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 17, 320, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 135, 95, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 620, 102, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35517, 170, 336, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(35517, 653, 335, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2749, 152, 335, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 23, 139, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 30, 153, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 496, 254, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 566, 229, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 100, 248, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 75, 125, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 576, 94, 0, 5026));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 135, 115, 0, 5026));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5011;
                case RoomExit.South: return 5041;
                case RoomExit.East:  return 5027;
                case RoomExit.West:  return 5025;
                default: return 0;
            }
        }
}
}
