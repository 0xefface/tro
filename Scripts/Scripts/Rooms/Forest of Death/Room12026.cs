using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12026 : Room
{
public Room12026()
: base(12026, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 122, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 574, 131, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 430, 135, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 487, 141, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 603, 140, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 177, 132, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 235, 151, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 402, 143, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 259, 136, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 344, 136, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 99, 133, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 44, 132, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 12, 210, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 425, 220, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 565, 271, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 620, 321, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 58, 201, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 163, 238, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 230, 310, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 45, 219, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 608, 259, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 309, 200, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 301, 105, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 104, 250, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 562, 143, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 419, 225, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 431, 214, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 551, 168, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 182, 334, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 321, 329, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 100, 327, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 4, 323, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 433, 324, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 367, 186, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 21, 220, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 173, 252, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 71, 214, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 363, 180, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 370, 196, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 422, 223, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 586, 272, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 582, 257, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 366, 183, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 200, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 200, 314, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 26, 243, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 145, 244, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 372, 189, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 225, 326, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 220, 119, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 296, 127, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 300, 159, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 348, 240, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 272, 253, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 304, 260, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 300, 139, 10, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 627, 168, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 469, 205, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 481, 195, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 488, 186, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 134, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 134, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 135, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 135, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 239, 148, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 149, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 143, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 144, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 132, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 133, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 131, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 131, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 140, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 140, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 140, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 142, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 142, 0, 12026));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 150, 0, 12026));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12021;
                case RoomExit.South: return 12031;
                case RoomExit.East:  return 12027;
                case RoomExit.West:  return 12025;
                default: return 0;
            }
        }
}
}
