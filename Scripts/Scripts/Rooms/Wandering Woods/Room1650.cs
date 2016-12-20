using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1650 : Room
{
public Room1650()
: base(1650, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 277, 330, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 396, 123, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 579, 140, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 131, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 294, 122, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 454, 149, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 331, 139, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 226, 136, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 534, 175, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 342, 330, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 482, 156, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 538, 214, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 581, 215, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 420, 204, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 159, 198, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 199, 194, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 516, 273, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 153, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 506, 151, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 30, 343, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 518, 214, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 491, 154, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 543, 208, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 639, 320, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 423, 311, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 223, 198, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 177, 198, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 165, 198, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 198, 198, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 512, 213, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 434, 214, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 407, 209, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 468, 293, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 316, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 263, 137, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 280, 115, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 292, 156, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 313, 253, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 326, 220, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 416, 216, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 365, 216, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 451, 209, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 408, 201, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 199, 214, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 411, 293, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 428, 217, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 290, 132, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 291, 156, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 315, 220, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 316, 264, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(132, 218, 197, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 567, 138, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 524, 241, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 125, 138, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 127, 135, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 72, 229, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 110, 214, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(191, 49, 231, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 40, 255, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 23, 299, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 112, 156, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 138, 99, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 91, 117, 0, 1650));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 124, 34, 0, 1650));



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
