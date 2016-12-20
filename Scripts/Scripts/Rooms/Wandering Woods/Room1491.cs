using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1491 : Room
{
public Room1491()
: base(1491, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 353, 128, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 508, 130, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 105, 134, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 522, 139, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 220, 136, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 111, 138, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 459, 138, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 571, 134, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 45, 143, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 286, 132, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 131, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 133, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 597, 139, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 600, 209, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 435, 264, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 341, 271, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 190, 215, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 172, 214, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 39, 258, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 117, 217, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 216, 214, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 64, 209, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 388, 268, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 330, 266, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 601, 210, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 204, 197, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 98, 265, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 597, 215, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 167, 214, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 144, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 143, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 136, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 138, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 137, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 135, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 135, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 130, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 131, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 316, 132, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 133, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 140, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 140, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 139, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 140, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 127, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 64, 200, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 203, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 59, 213, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32978, 199, 216, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 518, 215, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 351, 214, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 634, 217, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 616, 241, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 619, 258, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 410, 240, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 412, 252, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 115, 245, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 119, 259, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 262, 203, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 258, 251, 0, 1491));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 22, 253, 0, 1491));



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
