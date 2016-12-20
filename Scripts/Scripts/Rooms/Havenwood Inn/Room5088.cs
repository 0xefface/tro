using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5088 : Room
{
public Room5088()
: base(5088, "Havenwood Inn")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2505, 341, 42, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2506, 416, 84, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2506, 525, 35, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 332, 25, 65386, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2735, 448, 95, 26, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 704, 43, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 475, 171, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 277, 218, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2700, 439, 224, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2580, 577, 231, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 279, 219, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 310, 290, 65483, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 506, 188, 96, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 298, 79, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 395, 92, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 589, 235, 17, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 62, 236, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 55, 268, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 314, 84, 18, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 411, 97, 18, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 429, 98, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 392, 233, 96, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 72, 219, 60, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 30, 248, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 506, 114, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 48, 215, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 446, 185, 60, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 23, 218, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 35, 195, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 29, 109, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 20, 259, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 479, 425, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2607, 530, 192, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2957, 511, 294, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 518, 31, 65336, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 549, 280, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 424, 424, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 335, 57, 65386, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 321, 220, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 3, 241, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 27, 223, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 37, 269, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 261, 31, 65436, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 27, 121, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 247, 21, 65436, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 258, 195, 96, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 2, 87, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 279, 20, 65476, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 265, 24, 65476, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 11, 449, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 64, 449, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 92, 449, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 144, 449, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 172, 424, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 224, 425, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 631, 445, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 581, 445, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 556, 445, 0, 5088));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 505, 446, 0, 5088));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5073;
                case RoomExit.South: return 4013;
                case RoomExit.East:  return 5089;
                case RoomExit.West:  return 5087;
                default: return 0;
            }
        }
}
}
