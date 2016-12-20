using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1463 : Room
{
public Room1463()
: base(1463, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 247, 126, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 481, 133, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 142, 133, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 186, 139, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 308, 139, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 95, 207, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 338, 265, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 77, 200, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 43, 257, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 258, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 409, 260, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(134, 283, 189, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 565, 322, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 380, 225, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 345, 262, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 360, 225, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 284, 192, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 270, 138, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 138, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 139, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 145, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 136, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 135, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 131, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 131, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 131, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 29, 124, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 135, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 148, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 142, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 142, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 141, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 32, 195, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 153, 197, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 300, 187, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 135, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(205, 433, 104, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(205, 411, 118, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(217, 385, 134, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 355, 172, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 98, 230, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 340, 216, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 416, 131, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 380, 174, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 221, 185, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 204, 227, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 234, 229, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 27, 230, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 423, 111, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 262, 224, 0, 1463));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 677, 291, 0, 1463));



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
