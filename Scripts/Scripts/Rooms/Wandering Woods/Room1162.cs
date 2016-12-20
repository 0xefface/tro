using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1162 : Room
{
public Room1162()
: base(1162, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65523, 118, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 498, 129, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 362, 130, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 447, 139, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 616, 142, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 142, 133, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 213, 107, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 346, 138, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 139, 128, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 65, 134, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 30, 258, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 262, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 514, 268, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 215, 235, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 464, 253, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 114, 221, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 308, 199, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 131, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 136, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 611, 142, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 140, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 275, 132, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 14, 137, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 77, 244, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 99, 272, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 321, 203, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 425, 272, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 483, 268, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 459, 252, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 98, 216, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 55, 270, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 24, 257, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 43, 234, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 11, 325, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 154, 217, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 91, 265, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 348, 198, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 44, 281, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 143, 333, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 110, 283, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 1, 290, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 88, 338, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 137, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 149, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 160, 118, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 149, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 635, 142, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 137, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 132, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 132, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 134, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 134, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 136, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 131, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 131, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 257, 198, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 178, 117, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 208, 137, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 630, 199, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 364, 201, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 462, 199, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 295, 197, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 317, 201, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 376, 202, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 568, 201, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 590, 238, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 183, 128, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 301, 198, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 573, 235, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 418, 236, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 297, 234, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 233, 213, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 618, 236, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 180, 124, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 206, 141, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 529, 200, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 524, 233, 0, 1162));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 491, 184, 0, 1162));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1156;
                case RoomExit.South: return 1168;
                case RoomExit.East:  return 1163;
                case RoomExit.West:  return 1111;
                default: return 0;
            }
        }
}
}
