using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1234 : Room
{
public Room1234()
: base(1234, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 440, 103, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 509, 115, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 441, 264, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 79, 318, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 189, 144, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 145, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 428, 265, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 287, 2, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 126, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 280, 107, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 123, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 123, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 123, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 121, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 119, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 118, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 125, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 125, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 125, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 124, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 124, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 123, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 262, 104, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 258, 129, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 257, 108, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 253, 153, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 262, 202, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 266, 239, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 300, 237, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 274, 193, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 388, 214, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 558, 214, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 411, 221, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 576, 222, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 424, 256, 0, 1234));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 459, 258, 0, 1234));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1228;
                case RoomExit.South: return 1240;
                case RoomExit.East:  return 1235;
                case RoomExit.West:  return 1233;
                default: return 0;
            }
        }
}
}
