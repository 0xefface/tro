using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1357 : Room
{
public Room1357()
: base(1357, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 354, 127, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(1303, 628, 77, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 34, 103, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 466, 98, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 331, 149, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 386, 117, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 421, 133, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 421, 120, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 206, 135, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 140, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 420, 128, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 86, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 127, 142, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 16, 104, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 431, 326, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 303, 319, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 4, 251, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 119, 227, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 270, 230, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 324, 246, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(935, 34, 134, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(1262, 457, 107, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 128, 228, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 259, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 621, 79, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 164, 142, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 310, 310, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 409, 130, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 310, 310, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 454, 324, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 310, 310, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 310, 310, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 310, 310, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 461, 81, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 584, 103, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(1303, 603, 91, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 143, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 144, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 141, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 147, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 104, 98, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 131, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 130, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 31, 146, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(936, 68, 122, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 89, 105, 0, 1357));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 147, 0, 1357));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
