using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1163 : Room
{
public Room1163()
: base(1163, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 427, 124, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 191, 122, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 133, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 357, 246, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 437, 213, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 85, 201, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 108, 260, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 85, 200, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 167, 227, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 143, 256, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 609, 262, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 196, 265, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 171, 268, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 182, 239, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 169, 226, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 314, 258, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 376, 258, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 243, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 459, 215, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 264, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 97, 262, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 24, 205, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 70, 198, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 27, 203, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 144, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 144, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 151, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 151, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 142, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 633, 143, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 140, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 132, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 131, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 139, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 48, 201, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 182, 202, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 313, 201, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 447, 206, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 476, 337, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 385, 316, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 373, 252, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 555, 291, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 452, 206, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 239, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 220, 205, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 249, 236, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 118, 237, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 378, 238, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 361, 269, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 342, 268, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 573, 267, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 21, 234, 0, 1163));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 462, 279, 0, 1163));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1157;
                case RoomExit.South: return 1169;
                case RoomExit.East:  return 1164;
                case RoomExit.West:  return 1162;
                default: return 0;
            }
        }
}
}
