using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1688 : Room
{
public Room1688()
: base(1688, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 406, 138, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 579, 324, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 308, 292, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 298, 287, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 10, 204, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 346, 106, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 90, 251, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 106, 250, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 547, 165, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 36, 207, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 264, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 534, 153, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 549, 175, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 144, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 128, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 344, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 147, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 140, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 457, 139, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 481, 139, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 175, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 175, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 154, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 137, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 11, 319, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 49, 336, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 86, 329, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 97, 320, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 53, 297, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 205, 328, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 115, 307, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 267, 314, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 637, 317, 0, 1688));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 622, 268, 0, 1688));



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
