using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1242 : Room
{
public Room1242()
: base(1242, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(225, 284, 214, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 224, 214, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 599, 183, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 494, 198, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 392, 200, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 393, 188, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 295, 202, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 318, 191, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 276, 238, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 304, 237, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 217, 239, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 585, 168, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 65534, 95, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 312, 92, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 126, 230, 65509, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 73, 177, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 71, 210, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 544, 260, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 414, 196, 65496, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 67, 112, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 187, 178, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 580, 217, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 283, 170, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 495, 229, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 319, 118, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 409, 133, 65500, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 605, 217, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 194, 218, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 39, 178, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 372, 125, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 58, 217, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 147, 230, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 556, 154, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 162, 297, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 137, 250, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 26, 186, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 91, 131, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 108, 102, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 319, 104, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 23, 107, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 411, 115, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 138, 250, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 53, 186, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 604, 171, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 310, 290, 65499, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 408, 261, 65516, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 581, 192, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 506, 168, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2339, 457, 129, 65496, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 512, 170, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 621, 170, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 513, 171, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2355, 426, 154, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2357, 426, 135, 70, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2354, 426, 145, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2354, 426, 145, 20, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2354, 426, 135, 30, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2354, 426, 135, 50, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 518, 177, 20, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 615, 176, 20, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 518, 177, 30, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 615, 176, 30, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 518, 178, 50, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 615, 176, 50, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 518, 178, 70, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 615, 177, 70, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 518, 179, 90, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 615, 177, 90, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 518, 180, 110, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 615, 177, 110, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 582, 179, 65516, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 426, 180, 65516, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 445, 189, 20, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(2322, 567, 170, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 458, 284, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 458, 288, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 222, 230, 65516, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 525, 242, 65516, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 525, 155, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 396, 97, 65481, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 288, 154, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 130, 161, 0, 1242));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 256, 95, 0, 1242));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
