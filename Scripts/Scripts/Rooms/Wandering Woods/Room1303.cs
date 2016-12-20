using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1303 : Room
{
public Room1303()
: base(1303, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 461, 139, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 231, 135, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 526, 157, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 387, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 325, 140, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 506, 146, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 29, 199, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 392, 258, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 83, 219, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 91, 213, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 12, 320, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 225, 318, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 228, 217, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 601, 320, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 629, 247, 65509, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 548, 183, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 532, 116, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 532, 166, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 208, 111, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 360, 112, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 249, 144, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 163, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 190, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 137, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 482, 238, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 248, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 343, 263, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 42, 207, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 78, 204, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 100, 213, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 62, 220, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 412, 271, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 506, 250, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 480, 235, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 534, 171, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 519, 165, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 181, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 571, 187, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 335, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 577, 327, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 18, 318, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 415, 193, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 134, 205, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 163, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 131, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 136, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 141, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 141, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 138, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 243, 143, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 143, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 140, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 141, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 142, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 141, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 155, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 133, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 133, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 133, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 111, 223, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 228, 202, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 220, 195, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 293, 119, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 284, 161, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 285, 132, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 287, 119, 0, 1303));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 291, 172, 0, 1303));



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
