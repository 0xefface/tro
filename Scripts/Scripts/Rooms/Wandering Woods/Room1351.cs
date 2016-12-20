using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1351 : Room
{
public Room1351()
: base(1351, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 127, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 291, 131, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 155, 141, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 292, 131, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 325, 139, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 85, 136, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 44, 243, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 472, 210, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 604, 251, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 421, 260, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 210, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 332, 291, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 617, 261, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 180, 132, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 140, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 141, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 53, 281, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 103, 247, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 613, 261, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 456, 264, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 113, 227, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 332, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 6, 317, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 94, 211, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 59, 224, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 213, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 393, 265, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 389, 255, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 467, 247, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 598, 261, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 580, 246, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 550, 257, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 569, 254, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 207, 336, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 141, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 137, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 144, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 139, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 140, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 140, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 181, 131, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 131, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 131, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 138, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 40, 210, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 166, 210, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 399, 211, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 543, 210, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 482, 211, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 269, 127, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 348, 334, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 238, 143, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 293, 231, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 336, 268, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 269, 212, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 362, 256, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 215, 202, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 299, 207, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 461, 208, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 395, 249, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 98, 209, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 43, 242, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 242, 146, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 264, 257, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 258, 211, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 291, 296, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 267, 139, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 248, 126, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 246, 119, 0, 1351));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 628, 211, 0, 1351));



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
