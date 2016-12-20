using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6912 : Room
{
public Room6912()
: base(6912, "Valhalla Shops")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.UpDownLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 552, 167, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 437, 212, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2151, 17, 257, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 132, 148, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 40, 163, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 463, 170, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2102, 488, 221, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 600, 237, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2505, 629, 27, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 452, 7, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 65, 181, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 164, 8, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2517, 35, 10, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2518, 129, 28, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 244, 1, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 354, 2, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 315, 6, 65526, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 367, 31, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35527, 256, 139, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 254, 129, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35528, 257, 86, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 328, 41, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35529, 279, 101, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2762, 306, 41, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 279, 42, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 304, 25, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 340, 105, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 363, 173, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 346, 173, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 278, 171, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2759, 210, 170, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 342, 125, 65530, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 210, 119, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 212, 62, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35529, 408, 120, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 235, 169, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35528, 390, 123, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 234, 51, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 406, 171, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35530, 407, 50, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2760, 347, 34, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 148, 181, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 190, 69, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 169, 176, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 179, 168, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 424, 179, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 405, 72, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 406, 123, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 406, 55, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2763, 320, 94, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(35531, 298, 95, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 190, 121, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 405, 173, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 66, 195, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 88, 194, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 26, 152, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 107, 187, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 87, 183, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 107, 153, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 27, 203, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 45, 199, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 8, 167, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 453, 151, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 104, 100, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 128, 183, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 157, 166, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 126, 133, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 149, 146, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 65526, 205, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 65532, 50, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 65523, 155, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 174, 125, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 170, 75, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 7, 204, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 67, 141, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 149, 93, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 563, 187, 30, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 46, 111, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 127, 80, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 65529, 101, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 7, 117, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 168, 40, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 146, 44, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 86, 102, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 26, 101, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 64, 90, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 126, 56, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 105, 48, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 86, 52, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 43, 56, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 64, 38, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 23, 47, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 4, 66, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2761, 364, 81, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2506, 521, 40, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 426, 96, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 451, 130, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 429, 58, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 429, 129, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 450, 184, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 472, 185, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 493, 192, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 514, 195, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 541, 201, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 587, 207, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 608, 210, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 452, 81, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 564, 201, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 474, 86, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 471, 139, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 497, 145, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 520, 141, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 543, 149, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 565, 153, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 496, 92, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 592, 155, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 613, 159, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 546, 96, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 518, 91, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 615, 106, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 569, 100, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 589, 104, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 472, 41, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 496, 61, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 523, 41, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 571, 46, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 593, 52, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 546, 45, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 616, 78, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 618, 27, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 24, 237, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2649, 570, 255, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 371, 158, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 257, 153, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2147, 77, 243, 60, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(30829, 162, 210, 60, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 138, 223, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(34910, 49, 243, 60, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 566, 245, 60, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 188, 210, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(34914, 198, 213, 60, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2634, 346, 79, 40, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 660, 126, 50, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 256, 203, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2623, 46, 111, 50, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 583, 115, 50, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2642, 200, 151, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 362, 178, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 284, 78, 40, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 256, 181, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2648, 179, 226, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 546, 97, 40, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2624, 75, 95, 40, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2662, 408, 174, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2642, 200, 173, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2661, 408, 110, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2623, 65521, 120, 50, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2649, 39, 249, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2649, 114, 236, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2668, 373, 230, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2669, 427, 246, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2670, 508, 254, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2670, 65513, 250, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 645, 279, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 510, 257, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65524, 274, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 101, 256, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 362, 200, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 312, 161, 0, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2634, 403, 176, 65531, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 278, 175, 65531, 6912));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 637, 278, 0, 6912));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 6913;
                case RoomExit.East:  return 6911;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
