using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1122 : Room
{
public Room1122()
: base(1122, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 459, 102, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 658, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 50, 121, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 284, 283, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 401, 144, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 292, 284, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 297, 274, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 422, 146, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 412, 146, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 477, 115, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 133, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 224, 103, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 275, 156, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 271, 163, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 222, 126, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 224, 142, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 230, 127, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 234, 138, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 389, 183, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 559, 183, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 408, 189, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 569, 191, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 623, 204, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 349, 201, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 363, 217, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 468, 218, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 573, 220, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 348, 183, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 426, 183, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 286, 288, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 511, 185, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 23, 220, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 6, 213, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 63, 227, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 46, 214, 0, 1122));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 9, 219, 0, 1122));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1115;
                case RoomExit.South: return 1129;
                case RoomExit.East:  return 1123;
                case RoomExit.West:  return 1121;
                default: return 0;
            }
        }
}
}
