using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1371 : Room
{
public Room1371()
: base(1371, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(1305, 566, 100, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 91, 126, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 309, 131, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 438, 143, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 55, 134, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 299, 136, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 630, 132, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 374, 140, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 597, 149, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 502, 136, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 190, 135, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 430, 135, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 204, 237, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 606, 257, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 359, 257, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 609, 256, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 304, 247, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 128, 310, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 141, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 130, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 130, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 134, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 22, 137, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 242, 142, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 362, 132, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 55, 329, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 233, 240, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 131, 320, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65473, 126, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 652, 244, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 434, 305, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 134, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 137, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 137, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 51, 129, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 129, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 131, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 141, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 231, 142, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 139, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 139, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 149, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 149, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 149, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 149, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 142, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 141, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 141, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 133, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 139, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 140, 0, 1371));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 596, 116, 0, 1371));



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
