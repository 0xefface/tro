using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1251 : Room
{
public Room1251()
: base(1251, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 280, 141, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 517, 136, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 372, 328, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 480, 321, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 492, 323, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 89, 350, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 224, 218, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 599, 210, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 46, 264, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 347, 107, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 84, 268, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 130, 209, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 119, 214, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 354, 248, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 119, 220, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 23, 276, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 376, 270, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 139, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 139, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 141, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 138, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 138, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 135, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 135, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 145, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 145, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 140, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 308, 140, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 260, 140, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 139, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 139, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 144, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 18, 164, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 138, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 250, 193, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 264, 197, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 109, 222, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 346, 116, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 336, 146, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 342, 120, 0, 1251));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 343, 154, 0, 1251));



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
