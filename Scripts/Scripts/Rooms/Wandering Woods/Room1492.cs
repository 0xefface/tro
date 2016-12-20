using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1492 : Room
{
public Room1492()
: base(1492, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 606, 136, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 420, 125, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 492, 128, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 368, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 151, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 589, 139, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 336, 316, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 408, 314, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 383, 242, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 251, 246, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 325, 247, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 357, 124, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 238, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 233, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 416, 259, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 413, 245, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 592, 335, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 103, 246, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 173, 239, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 103, 226, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 52, 216, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 186, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 279, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 326, 124, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 321, 138, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 438, 135, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 393, 240, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 589, 320, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 338, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 149, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 144, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 145, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 145, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 137, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 137, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 602, 137, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 126, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 126, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 139, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 135, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 135, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 290, 242, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 87, 236, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 365, 244, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32982, 434, 242, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 500, 184, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 530, 168, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 512, 143, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 515, 254, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 501, 154, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 507, 189, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 529, 183, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 469, 259, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 389, 275, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 388, 294, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 192, 219, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 174, 281, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 167, 282, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 17, 276, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 531, 135, 0, 1492));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 522, 111, 0, 1492));



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
