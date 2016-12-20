using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1668 : Room
{
public Room1668()
: base(1668, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 314, 130, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 118, 129, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 499, 137, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 599, 144, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 123, 133, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 351, 139, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 244, 134, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 527, 143, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 40, 209, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 219, 237, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 487, 313, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 365, 256, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 190, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 19, 322, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 312, 248, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 550, 299, 10, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 552, 278, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 603, 302, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 617, 259, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 550, 333, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 551, 274, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 615, 260, 65506, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 627, 337, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 643, 286, 65516, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 508, 272, 65516, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 487, 315, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 474, 327, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 214, 234, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 243, 248, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 306, 246, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 335, 259, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 76, 200, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 43, 206, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 58, 220, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 50, 208, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 101, 212, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 218, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 106, 208, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 37, 221, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 132, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 133, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 132, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 132, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 134, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 133, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 127, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 140, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 138, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 138, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 139, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 139, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 142, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 144, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 145, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 59, 196, 0, 1668));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 196, 0, 1668));



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
