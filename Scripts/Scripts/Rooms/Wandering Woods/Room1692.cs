using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1692 : Room
{
public Room1692()
: base(1692, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 314, 130, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 118, 129, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 499, 137, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 599, 144, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 123, 133, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 351, 139, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 244, 134, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 527, 143, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 252, 239, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 487, 313, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 365, 256, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 190, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 19, 322, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 314, 328, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 557, 350, 10, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 634, 318, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 610, 336, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 631, 361, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 243, 248, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 50, 208, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 218, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 106, 208, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 37, 221, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 132, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 133, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 132, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 132, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 134, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 133, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 127, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 140, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 138, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 138, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 139, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 139, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 142, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 144, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 145, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 59, 196, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 196, 0, 1692));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 623, 362, 0, 1692));



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
