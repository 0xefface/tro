using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1282 : Room
{
public Room1282()
: base(1282, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 142, 130, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 380, 139, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 517, 144, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 620, 143, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 74, 135, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 396, 140, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 251, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 343, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 462, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 40, 208, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 308, 252, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 530, 267, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 578, 265, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 269, 262, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 438, 223, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 143, 240, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 593, 251, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 265, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 202, 239, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 254, 230, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 163, 241, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 296, 259, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 121, 236, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 421, 228, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 526, 275, 12, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 170, 240, 12, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 238, 240, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 136, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 134, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 139, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 127, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 140, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 139, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 139, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 141, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 139, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 412, 137, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 143, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 142, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 212, 124, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 204, 133, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 338, 182, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 378, 243, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 348, 191, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 334, 213, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 350, 253, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 234, 167, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 272, 175, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 326, 194, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 295, 184, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 481, 193, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 585, 192, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 460, 230, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 598, 140, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 18, 303, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 54, 317, 0, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 591, 264, 12, 1282));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 546, 261, 12, 1282));



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
