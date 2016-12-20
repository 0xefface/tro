using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12006 : Room
{
public Room12006()
: base(12006, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 464, 131, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 91, 126, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 309, 131, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 544, 150, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 55, 134, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 299, 136, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 635, 144, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 374, 140, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 472, 143, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 553, 142, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 190, 135, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 430, 135, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 426, 324, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 204, 237, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 606, 257, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 359, 257, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 609, 256, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 304, 247, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 128, 310, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 249, 274, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 96, 245, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 284, 275, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 240, 272, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 207, 258, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 22, 137, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 242, 142, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 362, 132, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 55, 329, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 233, 240, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 350, 254, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 295, 246, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 131, 320, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 440, 323, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65473, 126, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 458, 312, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 616, 257, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 652, 244, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 434, 305, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 134, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 137, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 137, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 51, 129, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 129, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 131, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 141, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 231, 142, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 139, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 139, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 149, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 149, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 149, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 149, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 142, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 141, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 141, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 133, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 139, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 140, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 134, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 130, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 130, 0, 12006));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 141, 0, 12006));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12001;
                case RoomExit.South: return 12011;
                case RoomExit.East:  return 12007;
                case RoomExit.West:  return 12005;
                default: return 0;
            }
        }
}
}
