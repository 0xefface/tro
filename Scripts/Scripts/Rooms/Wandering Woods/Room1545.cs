using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1545 : Room
{
public Room1545()
: base(1545, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 473, 130, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 140, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 201, 128, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 134, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 527, 138, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 569, 226, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 596, 292, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 424, 262, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 497, 238, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 256, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 222, 121, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 442, 226, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 495, 252, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 104, 227, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 364, 256, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 429, 245, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 103, 228, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 354, 227, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 202, 228, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 263, 226, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 175, 225, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 102, 269, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 339, 257, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 146, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 128, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 140, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 140, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 142, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 138, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 138, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 130, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 545, 137, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 137, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 142, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 142, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 131, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 126, 0, 1545));
this.AddRoomDecoration(RoomDecoration.FromCode(32902, 443, 241, 0, 1545));



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
