using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1253 : Room
{
public Room1253()
: base(1253, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 92, 123, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 536, 127, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 372, 128, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 138, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 572, 141, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 326, 138, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 138, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 292, 230, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 226, 218, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 430, 139, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 297, 232, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 154, 247, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 115, 239, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 266, 223, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 247, 110, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 240, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 139, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 282, 263, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 238, 220, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 220, 269, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 19, 232, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 220, 226, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 40, 245, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 258, 233, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 191, 311, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 142, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 138, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 87, 247, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 93, 254, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 130, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 362, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 142, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 408, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 385, 140, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 142, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 139, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 134, 208, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 177, 121, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 419, 143, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 438, 139, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 108, 255, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 7, 37, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 622, 207, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 607, 210, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 596, 317, 0, 1253));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 654, 314, 0, 1253));



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
