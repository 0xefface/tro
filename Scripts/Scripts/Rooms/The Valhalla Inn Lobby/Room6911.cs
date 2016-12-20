using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6911 : Room
{
public Room6911()
: base(6911, "The Valhalla Inn Lobby")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.UpDownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 157, 312, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 306, 180, 10, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2124, 282, 196, 60, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 97, 166, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 479, 312, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2128, 264, 135, 60, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 305, 218, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 306, 129, 20, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(34895, 336, 135, 60, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 33, 176, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 37, 141, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 57, 131, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(34989, 61, 70, 65436, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 16, 104, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 400, 153, 20, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 157, 11, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2506, 593, 36, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 461, 12, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2505, 566, 1, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 350, 17, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 244, 17, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 654, 187, 65526, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 651, 106, 50, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2662, 517, 175, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2662, 517, 86, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 141, 153, 20, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 157, 125, 20, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 416, 125, 20, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 111, 154, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 113, 118, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 107, 67, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 132, 119, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 174, 171, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 130, 168, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 193, 169, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 149, 170, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 132, 65, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 212, 159, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 210, 128, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 211, 79, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 232, 64, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 258, 71, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 281, 72, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 301, 68, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 321, 54, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 348, 61, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 375, 173, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 396, 174, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 377, 122, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 373, 69, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 417, 172, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 438, 174, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 472, 175, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 454, 173, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 399, 90, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 396, 62, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 471, 156, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(35528, 521, 173, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(35529, 517, 122, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 517, 72, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 468, 103, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 469, 51, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 448, 64, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 419, 67, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 187, 175, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 442, 178, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 439, 78, 40, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 187, 88, 50, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2633, 318, 94, 55, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 516, 174, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 541, 165, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 516, 82, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 517, 125, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 535, 115, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 604, 62, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 620, 191, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 620, 142, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 598, 115, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 622, 90, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 561, 79, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 581, 82, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 536, 62, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 515, 46, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 582, 40, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 562, 61, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 34, 87, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 56, 102, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 77, 88, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 56, 75, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 94, 174, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 94, 121, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 96, 93, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 75, 145, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 93, 74, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2624, 65518, 184, 65526, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2624, 65517, 106, 50, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 65531, 182, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 65533, 130, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 65532, 80, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 16, 155, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 411, 208, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 214, 205, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(34895, 280, 185, 80, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2124, 337, 186, 80, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(34896, 352, 196, 60, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2642, 104, 175, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2642, 104, 101, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2648, 389, 210, 65526, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 321, 224, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 760, 208, 65526, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(2670, 164, 208, 65526, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 586, 174, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65528, 211, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 65523, 232, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 237, 208, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 162, 197, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 213, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 230, 230, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 193, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 76, 186, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 376, 210, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 377, 230, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 409, 225, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 288, 224, 0, 6911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 174, 0, 6911));



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
