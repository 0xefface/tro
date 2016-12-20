using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1277 : Room
{
public Room1277()
: base(1277, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 114, 127, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 378, 133, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 141, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 580, 148, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 210, 126, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 386, 143, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 312, 142, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 281, 209, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 445, 239, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 544, 209, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 575, 326, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 179, 202, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 34, 258, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 328, 246, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 545, 208, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 142, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 137, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 142, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 147, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 137, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 137, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 259, 124, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 286, 135, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 142, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 301, 219, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 141, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 142, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 608, 138, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 129, 0, 1277));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 651, 214, 0, 1277));



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
