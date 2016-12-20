using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room7003 : Room
{
public Room7003()
: base(7003, "Wards of War")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2958, 85, 329, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2698, 335, 96, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 615, 237, 65431, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 346, 10, 65471, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 625, 13, 65470, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 457, 21, 65521, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 563, 29, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(35376, 501, 44, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 179, 46, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 464, 127, 70, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 356, 28, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 253, 22, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 208, 27, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 264, 41, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 421, 49, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 167, 20, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 257, 145, 7, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 167, 145, 7, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 461, 154, 7, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 256, 141, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 166, 141, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 460, 150, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 613, 177, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 448, 211, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 163, 192, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 622, 17, 65386, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 109, 177, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 572, 184, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 6, 220, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65520, 232, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 216, 178, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 300, 178, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 412, 192, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 27, 216, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 77, 18, 65470, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 635, 27, 65396, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 152, 184, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 215, 184, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 271, 187, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 439, 202, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 482, 202, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 317, 192, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 373, 203, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 345, 196, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2958, 426, 214, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 509, 199, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 411, 206, 0, 7003));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 233, 196, 0, 7003));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2922;
                case RoomExit.South: return 7009;
                case RoomExit.East:  return 7004;
                case RoomExit.West:  return 7002;
                default: return 0;
            }
        }
}
}
