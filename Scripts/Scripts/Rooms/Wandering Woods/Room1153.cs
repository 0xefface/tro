using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1153 : Room
{
public Room1153()
: base(1153, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 432, 107, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 627, 337, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 274, 355, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 50, 118, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 122, 127, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 531, 123, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 614, 117, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 581, 125, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 17, 328, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 30, 261, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 126, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 117, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 117, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 122, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 124, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 124, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 124, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 124, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 69, 114, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 116, 234, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 86, 307, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 252, 316, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 33, 117, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 41, 220, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 94, 276, 0, 1153));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 3, 205, 0, 1153));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1045;
                case RoomExit.South: return 1159;
                case RoomExit.East:  return 1154;
                case RoomExit.West:  return 1152;
                default: return 0;
            }
        }
}
}
