using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5045 : Room
{
public Room5045()
: base(5045, "West Leinster Chapel")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(3, 310, 161, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 286, 96, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 438, 63, 65440, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 16, 212, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 605, 7, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 477, 6, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 371, 62, 65440, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 110, 2, 65443, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 54, 1, 65437, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 353, 1, 65441, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 36, 137, 65476, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 22, 319, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 111, 105, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2791, 336, 79, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2702, 334, 89, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 301, 2, 65440, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 66, 198, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 142, 106, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 365, 3, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 481, 174, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 372, 174, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 454, 51, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 93, 64, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(35478, 366, 34, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 454, 131, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 91, 100, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 530, 163, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 166, 102, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 438, 9, 65464, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 371, 7, 65464, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 387, 130, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 387, 51, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 522, 153, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(32814, 366, 158, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 323, 183, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 65520, 325, 0, 5045));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 65520, 164, 0, 5045));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5030;
                case RoomExit.South: return 5060;
                case RoomExit.East:  return 5046;
                case RoomExit.West:  return 1029;
                default: return 0;
            }
        }
}
}
