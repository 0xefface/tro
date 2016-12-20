using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1290 : Room
{
public Room1290()
: base(1290, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 427, 124, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 191, 122, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 133, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 357, 246, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 432, 221, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 90, 208, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 108, 260, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 85, 200, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 167, 227, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 143, 256, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 300, 237, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 196, 265, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 171, 268, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 182, 239, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 169, 226, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 332, 263, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 376, 258, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 243, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 441, 235, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 264, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 97, 262, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 55, 213, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 70, 198, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 27, 203, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 144, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 144, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 151, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 151, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 142, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 633, 143, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 140, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 132, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 131, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 139, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 111, 247, 0, 1290));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 653, 258, 0, 1290));



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
