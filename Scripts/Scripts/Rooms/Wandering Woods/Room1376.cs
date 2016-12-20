using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1376 : Room
{
public Room1376()
: base(1376, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 149, 141, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 309, 140, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 141, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 523, 142, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 114, 216, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 336, 266, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 309, 321, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 406, 218, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 217, 221, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 477, 262, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 368, 221, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 599, 260, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 63, 320, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 114, 209, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 600, 263, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 121, 337, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 146, 304, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 54, 291, 65516, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 151, 335, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 47, 308, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65474, 339, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 0, 156, 28, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 234, 229, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 96, 220, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 121, 220, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 211, 219, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 327, 262, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 337, 244, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 406, 237, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 475, 236, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 581, 274, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 133, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 140, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 140, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 124, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 139, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 139, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 142, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 388, 141, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 141, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 139, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 143, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 142, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 142, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 96, 219, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 296, 219, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 359, 268, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 511, 220, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 580, 221, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 102, 218, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 195, 221, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 391, 223, 0, 1376));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 459, 266, 0, 1376));



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
