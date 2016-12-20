using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1682 : Room
{
public Room1682()
: base(1682, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(226, 343, 282, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 581, 118, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 370, 120, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 302, 207, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 581, 146, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 508, 134, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 319, 135, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 430, 137, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 346, 134, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 389, 149, 20, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 273, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 484, 142, 20, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 121, 139, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 528, 226, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 39, 299, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 522, 248, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 112, 186, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 164, 332, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 62, 221, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 156, 254, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 129, 189, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 569, 325, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 347, 199, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 537, 109, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 259, 221, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 340, 193, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 325, 186, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 535, 79, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 323, 207, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 120, 138, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 0, 303, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 135, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 137, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 136, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 385, 127, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 127, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 122, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 121, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 145, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 145, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 145, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 145, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 211, 133, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 217, 104, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 210, 110, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 169, 122, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 123, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 253, 160, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 261, 157, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 324, 197, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 305, 180, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 362, 209, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 512, 252, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 401, 223, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 358, 183, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 387, 208, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 129, 378, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 65, 379, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 45, 374, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 576, 383, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 521, 386, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 634, 382, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 4, 379, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 169, 353, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 450, 352, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 471, 353, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 121, 157, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 128, 123, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 124, 99, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 82, 116, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 508, 330, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 115, 328, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 139, 38, 0, 1682));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 38, 310, 0, 1682));



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
