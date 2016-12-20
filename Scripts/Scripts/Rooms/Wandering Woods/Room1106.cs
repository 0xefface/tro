using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1106 : Room
{
public Room1106()
: base(1106, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 28, 108, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 315, 105, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 122, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 123, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 172, 109, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 500, 127, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 171, 104, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 123, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 121, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 123, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 155, 34, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 557, 193, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 427, 193, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 288, 193, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 167, 212, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 154, 209, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 14, 222, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 150, 201, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 263, 268, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 390, 272, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 489, 267, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 327, 314, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 467, 272, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 602, 266, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 416, 193, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 516, 194, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 605, 194, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 473, 278, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 252, 295, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 313, 263, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 244, 262, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 330, 277, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 623, 117, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 634, 123, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 277, 291, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 311, 255, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 597, 261, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 456, 261, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 534, 259, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 221, 295, 0, 1106));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 480, 248, 0, 1106));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1103;
                case RoomExit.South: return 1111;
                case RoomExit.East:  return 1156;
                case RoomExit.West:  return 1105;
                default: return 0;
            }
        }
}
}
