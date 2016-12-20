using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1195 : Room
{
public Room1195()
: base(1195, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 226, 132, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 348, 138, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 372, 328, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 480, 321, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 492, 323, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 251, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 224, 218, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 599, 210, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 44, 257, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 269, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 169, 230, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 121, 223, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 385, 246, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 137, 231, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 23, 276, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 412, 295, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 139, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 139, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 141, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 138, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 138, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 135, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 135, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 145, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 145, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 363, 137, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 323, 137, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 137, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 139, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 139, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 144, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 18, 164, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 130, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 276, 231, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 296, 140, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 265, 109, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 259, 283, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 377, 292, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 466, 268, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 261, 126, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32976, 260, 205, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 254, 257, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 526, 182, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 563, 185, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 457, 185, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 68, 189, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 258, 332, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 65, 178, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 187, 252, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 273, 202, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 292, 183, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 290, 159, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 199, 176, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 258, 299, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 284, 140, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 302, 257, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 333, 176, 0, 1195));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 452, 178, 0, 1195));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1189;
                case RoomExit.South: return 1262;
                case RoomExit.East:  return 1196;
                case RoomExit.West:  return 1194;
                default: return 0;
            }
        }
}
}
