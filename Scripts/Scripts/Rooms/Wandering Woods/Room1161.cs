using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1161 : Room
{
public Room1161()
: base(1161, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 290, 103, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 105, 116, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 514, 210, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 489, 212, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 4, 126, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 218, 122, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 82, 104, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 459, 106, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 126, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 122, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 124, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 124, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 125, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 253, 124, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 128, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 129, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 342, 112, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 348, 104, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 341, 134, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 300, 156, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 291, 152, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 219, 172, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 77, 172, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 209, 176, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 62, 175, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 202, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 235, 123, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 558, 212, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 174, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 131, 174, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 516, 210, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 205, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 529, 208, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 261, 321, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 33, 145, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 155, 245, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 18, 127, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 87, 323, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 18, 264, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 612, 210, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 635, 284, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 613, 259, 0, 1161));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 668, 244, 0, 1161));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1155;
                case RoomExit.South: return 1167;
                case RoomExit.East:  return 4030;
                case RoomExit.West:  return 1160;
                default: return 0;
            }
        }
}
}
