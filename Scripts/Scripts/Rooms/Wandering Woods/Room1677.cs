using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1677 : Room
{
public Room1677()
: base(1677, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 481, 129, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 140, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 201, 128, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 639, 385, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 134, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 527, 138, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 569, 226, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 596, 292, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 424, 262, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 497, 238, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 621, 203, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 256, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 434, 109, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 209, 121, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 442, 226, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 495, 252, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 233, 344, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 372, 252, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 2, 334, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 103, 228, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 354, 227, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 202, 228, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 263, 226, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 175, 225, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 102, 269, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 339, 257, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 146, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 128, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 126, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 131, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 138, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 138, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 130, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 545, 137, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 137, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 142, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 142, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 66, 182, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 80, 170, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 252, 159, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 281, 164, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 152, 182, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 277, 173, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 206, 172, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 314, 123, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 99, 104, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(33000, 313, 101, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 349, 123, 0, 1677));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 392, 132, 0, 1677));



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
