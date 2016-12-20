using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1484 : Room
{
public Room1484()
: base(1484, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 89, 124, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 528, 123, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 302, 133, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 439, 138, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 619, 145, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 164, 138, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 565, 134, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 361, 145, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 268, 135, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 374, 134, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 508, 144, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 135, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 482, 242, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 25, 254, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 489, 319, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 134, 244, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 111, 285, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 607, 205, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 418, 247, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 258, 282, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 173, 188, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 482, 253, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 133, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 138, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 133, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 258, 144, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 138, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 379, 192, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 530, 264, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 267, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 247, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 399, 195, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 379, 197, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 507, 248, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 617, 218, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 605, 207, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 144, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 131, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 132, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 134, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 142, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 142, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 134, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 144, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 82, 212, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 200, 210, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 458, 206, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 580, 205, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 321, 122, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 294, 151, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 325, 210, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 319, 244, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 333, 295, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 334, 130, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 311, 161, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 315, 210, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 308, 256, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 421, 283, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 336, 340, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 331, 126, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 320, 186, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 122, 286, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 214, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 170, 192, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 504, 177, 0, 1484));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 507, 192, 0, 1484));


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
