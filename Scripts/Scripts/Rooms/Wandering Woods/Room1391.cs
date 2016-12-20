using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1391 : Room
{
public Room1391()
: base(1391, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 412, 138, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 145, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 64, 136, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 513, 142, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 397, 143, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 106, 130, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 16, 129, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 434, 220, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 302, 241, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 588, 242, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 560, 229, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 65534, 242, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32954, 149, 168, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 196, 242, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 37, 207, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 153, 265, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 311, 243, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 40, 203, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 51, 167, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 561, 146, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 22, 201, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 470, 228, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 214, 130, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 180, 136, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 138, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 278, 140, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 135, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 135, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 134, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 135, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 138, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 140, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 143, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 143, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 140, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 146, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 146, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 144, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 45, 249, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32987, 116, 138, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 138, 132, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 107, 178, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 262, 237, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 34, 232, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 35, 217, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 166, 239, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 5, 230, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 54, 188, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 463, 242, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 601, 244, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 549, 237, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 122, 237, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 557, 301, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 550, 275, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 275, 281, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 468, 285, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 160, 289, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 85, 251, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 144, 151, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 128, 129, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 617, 295, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 131, 110, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 541, 230, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 149, 129, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 101, 165, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 89, 210, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32954, 367, 282, 0, 1391));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 379, 232, 0, 1391));



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
