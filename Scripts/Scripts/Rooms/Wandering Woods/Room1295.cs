using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1295 : Room
{
public Room1295()
: base(1295, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 303, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 341, 140, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 28, 257, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 261, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 604, 322, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 127, 123, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 81, 266, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 91, 217, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 217, 220, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 438, 260, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 240, 138, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 541, 276, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 435, 267, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 344, 246, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 359, 266, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 434, 239, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 235, 231, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 109, 227, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 215, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 6, 269, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 19, 254, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 197, 229, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 446, 257, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 338, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 528, 271, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 529, 254, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 113, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 339, 117, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 532, 133, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 139, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 330, 140, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 145, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 145, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 150, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 151, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 141, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 130, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 131, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 294, 130, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32973, 260, 118, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 316, 163, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 643, 215, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 370, 212, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 482, 211, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 477, 267, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 278, 137, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 281, 153, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(32954, 354, 151, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 343, 228, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 418, 249, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 551, 248, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 249, 123, 0, 1295));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 623, 249, 0, 1295));



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
