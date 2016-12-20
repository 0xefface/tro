using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1365 : Room
{
public Room1365()
: base(1365, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 177, 136, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 12, 137, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 523, 136, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 357, 144, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 606, 136, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 534, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 473, 140, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 62, 142, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 239, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 22, 140, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 122, 140, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 632, 143, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 345, 129, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 199, 144, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 566, 228, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 540, 286, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 530, 261, 65523, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 181, 266, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 132, 278, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 572, 219, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 50, 268, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 396, 125, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 9, 233, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 233, 328, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 321, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 224, 243, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 400, 253, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 405, 259, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 577, 257, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 161, 283, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 83, 276, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 140, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 143, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 140, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 145, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 144, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 241, 137, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 263, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 137, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 326, 127, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 127, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 336, 141, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 142, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 142, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 457, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 139, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 143, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 142, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 134, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 134, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 133, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(33002, 292, 105, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 296, 109, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 297, 134, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 298, 139, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 303, 138, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 310, 191, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 63, 194, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 206, 191, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 394, 190, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 598, 174, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 459, 174, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 475, 186, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 491, 179, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 512, 171, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 493, 176, 0, 1365));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 305, 177, 0, 1365));



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
