using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1579 : Room
{
public Room1579()
: base(1579, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 384, 138, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 428, 134, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 145, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 64, 136, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 512, 142, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 436, 142, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 106, 130, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 16, 129, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 435, 220, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 302, 247, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 591, 268, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 574, 269, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 31, 212, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 220, 234, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 163, 239, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 37, 207, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 65, 200, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 281, 257, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 59, 216, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 250, 195, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 8, 203, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 478, 227, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 214, 130, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 138, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 278, 140, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 135, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 135, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 137, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 138, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 138, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 140, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 141, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 140, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 146, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 146, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 144, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 385, 123, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 343, 132, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 384, 227, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 352, 225, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 377, 172, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 391, 176, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 411, 178, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 378, 146, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 380, 126, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 422, 313, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(133, 656, 328, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 630, 312, 0, 1579));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 576, 324, 0, 1579));



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
