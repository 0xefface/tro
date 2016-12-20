using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5800 : Room
{
public Room5800()
: base(5800, "The Scimitar Tavern")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 219, 28, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 309, 57, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 402, 56, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 547, 40, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 467, 61, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 13, 305, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 486, 214, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 322, 86, 10, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 304, 81, 10, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 335, 75, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 117, 15, 65436, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 216, 170, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 32, 310, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 170, 16, 65436, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2614, 269, 83, 25, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2708, 544, 157, 80, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 415, 217, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 176, 3, 65436, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 381, 178, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 198, 3, 65436, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 205, 151, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 392, 197, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 23, 110, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 374, 208, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 609, 180, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 509, 261, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 451, 229, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 515, 195, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 188, 180, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1507, 178, 24, 65386, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 448, 87, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2614, 344, 93, 25, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2804, 567, 212, 100, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 490, 177, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 584, 162, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 115, 264, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 571, 241, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 65512, 235, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 65473, 203, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 29, 197, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 2, 194, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 246, 188, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 156, 175, 65526, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 503, 259, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 504, 260, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 429, 162, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 425, 217, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 428, 148, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 456, 149, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 456, 214, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 456, 175, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 344, 204, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 340, 163, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 250, 187, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 250, 136, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 165, 173, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 170, 106, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2753, 169, 156, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 340, 138, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 246, 118, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 194, 74, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 222, 79, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2751, 371, 84, 65516, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2752, 403, 79, 65506, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 586, 42, 65531, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 567, 50, 65531, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 628, 62, 65531, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 535, 180, 65506, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 621, 47, 65531, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 553, 191, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 532, 156, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 551, 139, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 525, 209, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 563, 201, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 593, 194, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 638, 191, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 486, 56, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 531, 56, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 509, 51, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 623, 118, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 627, 67, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 611, 58, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 552, 41, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 570, 41, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2757, 591, 45, 65486, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2756, 607, 49, 65531, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2755, 523, 45, 65496, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2758, 546, 50, 65526, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 563, 213, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(2794, 561, 208, 85, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 262, 217, 0, 5800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 260, 197, 0, 5800));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21447;
                case RoomExit.South: return 5803;
                case RoomExit.East:  return 5801;
                case RoomExit.West:  return 21660;
                default: return 0;
            }
        }
}
}
