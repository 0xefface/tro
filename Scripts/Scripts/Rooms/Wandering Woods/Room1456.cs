using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1456 : Room
{
public Room1456()
: base(1456, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 114, 127, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 378, 133, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 141, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 580, 148, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 191, 128, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 386, 143, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 312, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 300, 207, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 479, 222, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 544, 209, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 575, 326, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 179, 202, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 164, 223, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 346, 223, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 612, 319, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 545, 208, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 137, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 147, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 137, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 137, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 259, 124, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 286, 135, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 316, 223, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 141, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 608, 138, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 129, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 230, 107, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 267, 275, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 219, 142, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 225, 117, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 219, 167, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 132, 221, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 233, 166, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 233, 141, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 65510, 218, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 272, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 248, 216, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 375, 219, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 538, 224, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 637, 224, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 66, 251, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 69, 259, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 192, 257, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 305, 254, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 309, 262, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 440, 251, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 443, 263, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 600, 254, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 603, 265, 0, 1456));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 18, 256, 0, 1456));



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
