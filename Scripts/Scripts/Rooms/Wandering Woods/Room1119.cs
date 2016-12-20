using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1119 : Room
{
public Room1119()
: base(1119, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 377, 145, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 145, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 633, 142, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 324, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 627, 121, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 123, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 374, 160, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 312, 106, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 306, 109, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 306, 135, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 291, 232, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 274, 238, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 307, 160, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 303, 172, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 308, 185, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 375, 152, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 55, 327, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 392, 155, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 357, 154, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 375, 159, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 394, 160, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 351, 154, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 344, 148, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 407, 161, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 404, 151, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 383, 162, 0, 1119));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 400, 155, 0, 1119));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1112;
                case RoomExit.South: return 1126;
                case RoomExit.East:  return 1120;
                case RoomExit.West:  return 1118;
                default: return 0;
            }
        }
}
}
