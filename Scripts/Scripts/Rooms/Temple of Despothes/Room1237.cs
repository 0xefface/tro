using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1237 : Room
{
public Room1237()
: base(1237, "Temple of Despothes")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.UpDown;
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 594, 163, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 472, 160, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2272, 317, 190, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 471, 174, 90, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 164, 170, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 157, 162, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 109, 206, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2252, 318, 196, 46, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 378, 72, 65426, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2350, 108, 364, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 92, 210, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 353, 312, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 211, 184, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 318, 196, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 606, 169, 50, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 570, 162, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 442, 185, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 627, 161, 120, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2254, 373, 170, 20, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 606, 169, 70, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 317, 193, 160, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 606, 169, 30, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 327, 66, 65406, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 606, 169, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35022, 263, 170, 20, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2392, 260, 184, 145, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 560, 208, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 546, 211, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 319, 175, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 318, 88, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 187, 185, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 91, 207, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 606, 172, 90, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 527, 208, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 543, 208, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 207, 70, 65436, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2259, 320, 201, 56, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 615, 305, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 471, 169, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 95, 289, 65514, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 568, 161, 120, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 307, 66, 65406, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 44, 161, 120, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2339, 423, 70, 65436, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2392, 264, 71, 65426, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 48, 162, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 206, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 570, 180, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35080, 90, 207, 65524, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 477, 161, 120, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2255, 370, 195, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 606, 169, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2327, 310, 164, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 378, 181, 140, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35023, 265, 195, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 66, 178, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35080, 543, 209, 65526, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 149, 160, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 164, 171, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 471, 169, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 164, 171, 30, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 471, 170, 30, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 164, 171, 50, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 471, 172, 70, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 153, 161, 120, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 479, 162, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 164, 171, 70, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 164, 172, 90, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 471, 171, 50, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 312, 72, 65436, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 554, 160, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 544, 223, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 618, 159, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 91, 224, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 48, 160, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 460, 185, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 388, 317, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 30, 170, 90, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 30, 170, 70, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 30, 170, 50, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 30, 169, 30, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 30, 169, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 30, 169, 10, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 284, 199, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 306, 205, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 329, 205, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 352, 200, 0, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 36, 304, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 476, 310, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 176, 309, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 547, 292, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 12, 282, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 598, 288, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 374, 301, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 282, 301, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 176, 300, 65516, 1237));
this.AddRoomDecoration(RoomDecoration.FromCode(35765, 469, 301, 65516, 1237));


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
