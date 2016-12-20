using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1560 : Room
{
public Room1560()
: base(1560, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 76, 132, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 336, 124, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 505, 129, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 454, 142, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 147, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 179, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 242, 140, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 346, 146, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 294, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 147, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 114, 133, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 48, 132, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 38, 210, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 447, 232, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 597, 256, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 412, 270, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 266, 215, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 17, 329, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 239, 198, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 258, 227, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 130, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 51, 208, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 60, 197, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 299, 231, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 351, 246, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 251, 210, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 309, 210, 65516, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 202, 240, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 315, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 129, 208, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 272, 244, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 139, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 140, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 140, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 138, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 321, 146, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 145, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 145, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 147, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 147, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 147, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 141, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 144, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 197, 0, 1560));
this.AddRoomDecoration(RoomDecoration.FromCode(138, 42, 309, 0, 1560));



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
