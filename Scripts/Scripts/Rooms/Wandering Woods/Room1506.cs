using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1506 : Room
{
public Room1506()
: base(1506, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 461, 139, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 227, 138, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 526, 157, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 387, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 335, 140, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 506, 146, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 29, 199, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 392, 258, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 83, 219, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 91, 213, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 42, 315, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 320, 249, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 626, 329, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 601, 320, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 629, 247, 65509, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 548, 183, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 532, 116, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 532, 166, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 208, 111, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 360, 112, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 309, 148, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 163, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 184, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 137, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 482, 238, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 248, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 343, 263, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 42, 207, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 78, 204, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 100, 213, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 62, 220, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 412, 271, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 506, 250, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 480, 235, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 534, 171, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 519, 165, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 181, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 571, 187, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 335, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 577, 327, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 18, 318, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 415, 193, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 134, 205, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 163, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 131, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 136, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 141, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 141, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 137, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 148, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 147, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 140, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 141, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 142, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 141, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 155, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 133, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 133, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 137, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 283, 116, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 260, 163, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 249, 159, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 276, 139, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 278, 119, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 219, 210, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 211, 219, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 172, 178, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 185, 181, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 238, 218, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 111, 219, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 126, 211, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 315, 273, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 270, 262, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 275, 257, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 312, 259, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 222, 314, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 141, 204, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 65512, 263, 0, 1506));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 65507, 303, 0, 1506));


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
