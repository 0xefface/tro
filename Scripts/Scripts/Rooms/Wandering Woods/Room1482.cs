using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1482 : Room
{
public Room1482()
: base(1482, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65503, 129, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 422, 131, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 359, 132, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 622, 143, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 134, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 137, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 147, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 175, 130, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 529, 137, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 409, 270, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 489, 260, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 491, 239, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 425, 266, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 210, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 598, 195, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 26, 255, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 100, 247, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 111, 247, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 131, 248, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 233, 230, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 206, 211, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 83, 226, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 47, 268, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65532, 254, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 265, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 258, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 452, 254, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 438, 246, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 129, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 643, 212, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 83, 337, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 568, 334, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 231, 206, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 500, 235, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 439, 252, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 145, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 137, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 129, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 136, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 136, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 136, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 137, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 145, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 132, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 133, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 135, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 135, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 103, 214, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 299, 212, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 256, 210, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 559, 199, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 408, 204, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 379, 209, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 169, 343, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65526, 346, 0, 1482));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65520, 278, 0, 1482));



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
