using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1286 : Room
{
public Room1286()
: base(1286, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 138, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 150, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 201, 127, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 281, 140, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 622, 256, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 444, 222, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 279, 258, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 294, 323, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 76, 196, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 332, 244, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 300, 245, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 31, 196, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 142, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 104, 290, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 183, 292, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 91, 328, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 137, 299, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 392, 343, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 504, 313, 65516, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 284, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 52, 216, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 84, 215, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 319, 262, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 366, 255, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 344, 239, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 301, 245, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 156, 74, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 620, 266, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 435, 225, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 286, 240, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 16, 280, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 458, 220, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 104, 294, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 171, 305, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 141, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 140, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 140, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 140, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 137, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 144, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 144, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 151, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 151, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 79, 200, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 532, 222, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 557, 221, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 203, 178, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 199, 185, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 339, 177, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 462, 226, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 367, 206, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 392, 256, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 387, 248, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 388, 205, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 395, 198, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 377, 190, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 23, 199, 0, 1286));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 74, 194, 0, 1286));



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
