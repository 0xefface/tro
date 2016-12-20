using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1156 : Room
{
public Room1156()
: base(1156, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 267, 128, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 145, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 64, 136, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 513, 142, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 434, 135, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 314, 138, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 106, 130, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 16, 129, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 442, 213, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 302, 247, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 591, 268, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 574, 269, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 31, 212, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 220, 234, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 163, 239, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 37, 207, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 65, 200, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 296, 256, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 60, 212, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 250, 195, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 8, 203, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 478, 227, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 214, 130, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 138, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 278, 140, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 135, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 135, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 137, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 138, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 138, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 132, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 459, 136, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 137, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 134, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 140, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 146, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 146, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 144, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 524, 180, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 573, 180, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 484, 180, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 386, 187, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 285, 183, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 202, 182, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 84, 190, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 94, 203, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 110, 193, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 65532, 210, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 345, 184, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 430, 263, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 377, 213, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 358, 269, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 362, 126, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 417, 185, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(217, 396, 89, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 390, 119, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 343, 277, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 383, 281, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 377, 228, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 381, 188, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 372, 129, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 363, 334, 0, 1156));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 382, 118, 0, 1156));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1150;
                case RoomExit.South: return 1162;
                case RoomExit.East:  return 1157;
                case RoomExit.West:  return 1106;
                default: return 0;
            }
        }
}
}
