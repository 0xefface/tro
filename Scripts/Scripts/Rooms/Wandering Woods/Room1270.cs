using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1270 : Room
{
public Room1270()
: base(1270, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 122, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 574, 131, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 399, 134, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 487, 141, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 603, 140, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 177, 132, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 235, 151, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 402, 143, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 259, 136, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 344, 136, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 99, 133, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 44, 132, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 12, 210, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 425, 220, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 565, 271, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 620, 321, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 58, 201, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 163, 238, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 230, 310, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 134, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 608, 259, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 142, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 239, 148, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 135, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 562, 143, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 140, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 140, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 132, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 182, 334, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 321, 329, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 100, 327, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 4, 323, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 433, 324, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 367, 186, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 21, 220, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 173, 252, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 71, 214, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 363, 180, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 370, 196, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 422, 223, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 586, 272, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 582, 257, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 366, 183, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 200, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 200, 314, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 26, 243, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 145, 244, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 372, 189, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 225, 326, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 220, 119, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 149, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 143, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 142, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 150, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 140, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 135, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 144, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 131, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 131, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 133, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 134, 0, 1270));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 657, 315, 0, 1270));



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
