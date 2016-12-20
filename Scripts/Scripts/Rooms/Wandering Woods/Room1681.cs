using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1681 : Room
{
public Room1681()
: base(1681, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65506, 122, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 438, 134, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 218, 129, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 617, 127, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 140, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 471, 236, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 278, 224, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 63, 262, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 118, 235, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 36, 256, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 172, 338, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 552, 351, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 583, 321, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 32924, 524, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 154, 205, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 131, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 141, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 170, 142, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 127, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 145, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 144, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 144, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 140, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 140, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 138, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 144, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 144, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 131, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 145, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 141, 258, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 101, 251, 0, 1681));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 113, 261, 0, 1681));



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
