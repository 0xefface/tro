using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1675 : Room
{
public Room1675()
: base(1675, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 99, 126, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 336, 136, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 547, 155, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 235, 141, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 545, 172, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 146, 136, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 203, 132, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 145, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 82, 135, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 31, 133, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 473, 237, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 245, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 592, 252, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 96, 228, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 31, 257, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 398, 258, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 367, 229, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 583, 251, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 627, 288, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 305, 137, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 505, 152, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 525, 164, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 509, 165, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 355, 263, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 603, 289, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 634, 280, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 439, 269, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 96, 266, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 127, 218, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 343, 241, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 135, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 135, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 136, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 136, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 130, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 140, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 139, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 139, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 135, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 136, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 141, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 138, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 445, 138, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 172, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 350, 230, 0, 1675));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 426, 260, 0, 1675));


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
