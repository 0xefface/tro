using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1157 : Room
{
public Room1157()
: base(1157, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 304, 138, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 128, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 330, 140, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 76, 131, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 436, 244, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 486, 238, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 315, 319, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 147, 220, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 100, 230, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 114, 216, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 36, 258, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 226, 219, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 146, 205, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 226, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 65510, 263, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 256, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 246, 229, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 226, 215, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 107, 214, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 305, 309, 65516, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 352, 307, 65516, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 496, 218, 65516, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 435, 223, 65516, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 338, 340, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 434, 273, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 280, 228, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 439, 254, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 138, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 129, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 126, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 137, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 139, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 144, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 145, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 134, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 135, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 595, 144, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 144, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 247, 161, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 282, 136, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 289, 118, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 157, 176, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 65, 176, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 240, 155, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 223, 201, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 98, 202, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 161, 176, 0, 1157));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 74, 175, 0, 1157));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1151;
                case RoomExit.South: return 1163;
                case RoomExit.East:  return 1158;
                case RoomExit.West:  return 1156;
                default: return 0;
            }
        }
}
}
