using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1527 : Room
{
public Room1527()
: base(1527, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65506, 122, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 438, 134, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 218, 129, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 617, 127, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 140, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 195, 208, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 465, 259, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 209, 200, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 81, 261, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 233, 206, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 36, 256, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 545, 213, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 586, 206, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 598, 205, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 32924, 524, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 154, 205, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 131, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 141, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 170, 142, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 127, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 145, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 144, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 144, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 140, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 140, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 138, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 144, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 144, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 131, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 145, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 607, 196, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 621, 196, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 558, 212, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 360, 212, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 176, 211, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 62, 213, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 232, 207, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 475, 251, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 371, 260, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 441, 255, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 488, 260, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 177, 208, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 570, 209, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 601, 211, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 21, 262, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 401, 251, 0, 1527));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 631, 211, 0, 1527));



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
