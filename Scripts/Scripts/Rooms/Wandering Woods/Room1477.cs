using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1477 : Room
{
public Room1477()
: base(1477, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 221, 127, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 141, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 128, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 115, 129, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 4, 167, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 436, 244, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 490, 236, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 258, 319, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 147, 220, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 100, 230, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 399, 239, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 65515, 104, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 639, 205, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(938, 58, 124, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 226, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 65510, 263, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 256, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 246, 229, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 226, 215, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 107, 214, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 305, 309, 65516, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 352, 307, 65516, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 496, 218, 65516, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 435, 223, 65516, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 338, 340, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 434, 273, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 280, 228, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 444, 242, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 138, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 38, 164, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 5, 168, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 24, 168, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 137, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 139, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 144, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 145, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 134, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 135, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 595, 144, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 144, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(935, 3, 134, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(7905, 34, 149, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 21, 315, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 75, 114, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 17, 119, 0, 1477));
this.AddRoomDecoration(RoomDecoration.FromCode(7905, 65512, 178, 0, 1477));



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
