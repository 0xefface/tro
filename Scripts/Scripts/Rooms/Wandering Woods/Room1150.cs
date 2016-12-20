using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1150 : Room
{
public Room1150()
: base(1150, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 119, 116, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 224, 318, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 188, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 191, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 160, 190, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 359, 103, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 531, 113, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 110, 122, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 593, 124, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 209, 113, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 173, 323, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 63, 112, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 261, 319, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 98, 322, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 4, 119, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 110, 187, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 46, 178, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 80, 183, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 121, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 121, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 124, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 124, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 124, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 124, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 81, 209, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 53, 174, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 330, 212, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 203, 212, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 461, 290, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 398, 255, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32968, 460, 241, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(201, 447, 262, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 431, 221, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 466, 271, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 521, 261, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 496, 242, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 282, 254, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 533, 271, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 509, 254, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 181, 252, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 213, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 179, 212, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 516, 289, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 283, 296, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 381, 267, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 389, 241, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 286, 249, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 125, 246, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 66, 234, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 107, 278, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 39, 153, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 65530, 203, 0, 1150));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 446, 345, 0, 1150));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1042;
                case RoomExit.South: return 1156;
                case RoomExit.East:  return 1151;
                case RoomExit.West:  return 1103;
                default: return 0;
            }
        }
}
}
