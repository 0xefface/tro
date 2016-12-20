using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1500 : Room
{
public Room1500()
: base(1500, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 374, 123, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 509, 135, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 570, 141, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 340, 133, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 407, 138, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 458, 143, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 277, 199, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 561, 287, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 601, 276, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 558, 230, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 13, 271, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 5, 328, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 254, 201, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 115, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 159, 114, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 634, 323, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 427, 202, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 582, 286, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 311, 299, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 365, 328, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 319, 326, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 380, 336, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 159, 257, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 475, 211, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 87, 268, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 121, 221, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 142, 232, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 195, 214, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 190, 229, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 362, 228, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 361, 270, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 612, 270, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 554, 197, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 574, 205, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 535, 206, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 543, 305, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 393, 210, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 281, 206, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 316, 193, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 408, 337, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 533, 269, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 142, 218, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 158, 227, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 68, 293, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 474, 188, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 315, 242, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 145, 319, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 404, 246, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65517, 264, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 196, 120, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 178, 247, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 110, 208, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 89, 330, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 425, 280, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 334, 328, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 10, 306, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 404, 317, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 612, 143, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 361, 276, 65506, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 133, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 133, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 99, 140, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 54, 146, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 140, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 134, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 134, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 143, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 141, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 134, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 133, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 637, 123, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 138, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 637, 111, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 139, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 445, 143, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 55, 231, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 198, 230, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32978, 349, 228, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 514, 225, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 615, 226, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 124, 268, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 128, 275, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 291, 258, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 294, 273, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 570, 260, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 608, 267, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 462, 217, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 444, 265, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 22, 268, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 568, 272, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 670, 300, 0, 1500));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 650, 231, 0, 1500));



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
