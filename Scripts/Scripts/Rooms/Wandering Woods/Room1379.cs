using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1379 : Room
{
public Room1379()
: base(1379, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 106, 122, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 287, 118, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 549, 129, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 578, 133, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 142, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 462, 143, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 524, 135, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 241, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 344, 147, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 178, 146, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 98, 143, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 515, 139, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 485, 214, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 429, 261, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 254, 136, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 311, 242, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 599, 321, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 218, 325, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 120, 232, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 379, 135, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 309, 132, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 287, 239, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 347, 229, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 329, 330, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 500, 212, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 145, 230, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 141, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 141, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 144, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 146, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 146, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 137, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 132, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 143, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 142, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 139, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 139, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 149, 232, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 177, 230, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 14, 240, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 23, 226, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 336, 260, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 535, 263, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 97, 232, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 237, 315, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 505, 256, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 533, 312, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 133, 240, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 498, 263, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 443, 265, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1305, 311, 83, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1306, 101, 69, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(34074, 238, 81, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 433, 85, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(34073, 519, 66, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 483, 115, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 143, 110, 0, 1379));
this.AddRoomDecoration(RoomDecoration.FromCode(1306, 108, 102, 0, 1379));



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
