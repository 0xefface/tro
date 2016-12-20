using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5911 : Room
{
public Room5911()
: base(5911, "Valhalla Inn")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 25, 39, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 135, 56, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 82, 63, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 528, 152, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 503, 55, 65436, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 367, 31, 100, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 391, 64, 20, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 499, 179, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 181, 246, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 528, 167, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 485, 178, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 125, 237, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 180, 246, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 512, 101, 65486, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 519, 26, 65436, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2700, 351, 261, 150, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 504, 36, 65436, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 323, 74, 20, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 232, 59, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 459, 23, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 457, 22, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 386, 33, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 178, 136, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2614, 48, 163, 100, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 28, 184, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 316, 162, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 218, 182, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 116, 182, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 17, 165, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 244, 200, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 187, 213, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 341, 180, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 127, 201, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 65523, 139, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 93, 117, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 5, 72, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 65525, 175, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 160, 180, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 379, 96, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 358, 107, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 185, 170, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 118, 110, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 62, 138, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 186, 174, 65486, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 86, 194, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 187, 135, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2754, 82, 131, 65496, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 283, 156, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 486, 176, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 487, 123, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 483, 76, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 484, 41, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 285, 187, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 65517, 70, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 265, 164, 65486, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 206, 114, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 263, 116, 65486, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 363, 184, 65526, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 361, 147, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 381, 175, 65526, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65515, 188, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 467, 83, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 47, 106, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 230, 101, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 252, 123, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 248, 74, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 380, 121, 65526, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 160, 111, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 231, 130, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 275, 112, 65526, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 155, 194, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 292, 71, 40, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 270, 88, 20, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 296, 127, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 317, 118, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 21, 104, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 64, 189, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 313, 110, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 291, 115, 40, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 49, 125, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 467, 130, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 468, 159, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 338, 111, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 70, 104, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 294, 204, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 100, 135, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 370, 190, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 140, 105, 65516, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 57, 204, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(35382, 411, 259, 180, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2623, 289, 131, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2624, 373, 117, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2623, 187, 146, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 332, 121, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 353, 109, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 375, 106, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 394, 97, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 414, 93, 40, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 436, 62, 20, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 456, 88, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 470, 91, 50, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 250, 235, 0, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 346, 228, 150, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 17, 345, 20, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 517, 9, 65426, 5911));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 99, 185, 0, 5911));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5908;
                case RoomExit.South: return 1281;
                case RoomExit.East:  return 1265;
                case RoomExit.West:  return 5910;
                default: return 0;
            }
        }
}
}
