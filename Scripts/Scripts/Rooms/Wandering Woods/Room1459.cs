using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1459 : Room
{
public Room1459()
: base(1459, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 535, 139, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 143, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 177, 140, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 358, 145, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 489, 146, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 138, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 68, 140, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 450, 140, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 405, 140, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 123, 141, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 136, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 611, 318, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 448, 269, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 244, 216, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 347, 253, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 409, 258, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 257, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 234, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 491, 237, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 139, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 267, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 255, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 234, 225, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 352, 257, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 431, 272, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 349, 265, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 395, 256, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 487, 236, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 517, 246, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 381, 243, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 614, 332, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 141, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 136, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 138, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 144, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 140, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 139, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 139, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 142, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 232, 252, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 221, 187, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 103, 185, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 37, 186, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 115, 216, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 173, 219, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 204, 324, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 306, 326, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 252, 329, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 328, 227, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 155, 231, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 193, 248, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 283, 228, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 276, 236, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 155, 255, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 26, 216, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 647, 204, 0, 1459));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 691, 321, 0, 1459));



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
