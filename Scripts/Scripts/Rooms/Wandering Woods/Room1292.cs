using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1292 : Room
{
public Room1292()
: base(1292, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 412, 138, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 145, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 64, 136, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 513, 142, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 397, 143, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 106, 130, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 16, 129, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 434, 220, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 302, 247, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 591, 268, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 574, 269, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 31, 212, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 220, 234, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 163, 239, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 37, 207, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 144, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 326, 259, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 59, 216, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 250, 195, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 8, 203, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 478, 227, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 214, 130, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 138, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 278, 140, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 135, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 135, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 137, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 138, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 138, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 140, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 143, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 143, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 140, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 146, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 146, 0, 1292));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 65524, 307, 0, 1292));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
