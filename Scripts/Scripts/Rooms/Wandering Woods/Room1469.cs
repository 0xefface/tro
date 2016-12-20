using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1469 : Room
{
public Room1469()
: base(1469, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 106, 122, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 287, 118, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 549, 129, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 578, 133, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 142, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 462, 143, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 524, 135, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 241, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 344, 147, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 178, 146, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 98, 143, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 515, 139, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 171, 200, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 346, 247, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 492, 236, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 254, 136, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 54, 194, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 610, 320, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 136, 207, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 605, 257, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 379, 135, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 309, 132, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 84, 199, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 146, 205, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 42, 220, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 251, 207, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 420, 334, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 141, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 141, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 144, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 146, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 146, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 137, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 132, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 143, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 142, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 139, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 139, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 92, 250, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(932, 256, 352, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(33715, 6, 256, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 375, 320, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 189, 198, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 234, 292, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 97, 203, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 253, 197, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 330, 198, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 597, 204, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 488, 202, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 160, 236, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 272, 235, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 534, 240, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 419, 183, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 410, 231, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 51, 536, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 163, 535, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 611, 239, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 268, 325, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 154, 325, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 46, 325, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 264, 301, 0, 1469));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 236, 279, 0, 1469));



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
