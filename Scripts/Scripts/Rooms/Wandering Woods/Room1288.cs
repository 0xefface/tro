using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1288 : Room
{
public Room1288()
: base(1288, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 177, 136, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 12, 137, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 523, 136, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 390, 142, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 606, 136, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 534, 138, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 473, 140, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 62, 142, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 246, 139, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 22, 140, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 122, 140, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 632, 143, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 360, 135, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 199, 144, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 566, 228, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 540, 286, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 404, 250, 65523, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 190, 257, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 132, 278, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 572, 219, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 50, 268, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 309, 130, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 233, 328, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 534, 276, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 224, 243, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 400, 253, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 405, 259, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 577, 257, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 161, 283, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 83, 276, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 140, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 143, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 140, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 145, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 144, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 237, 137, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 137, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 137, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 134, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 344, 134, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 141, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 141, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 141, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 457, 138, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 138, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 139, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 143, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 142, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 134, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 134, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 133, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 73, 221, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 270, 204, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 413, 205, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 585, 202, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 310, 165, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 322, 117, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 318, 137, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 319, 117, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 320, 164, 0, 1288));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 358, 203, 0, 1288));



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
