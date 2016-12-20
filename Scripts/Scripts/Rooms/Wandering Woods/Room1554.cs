using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1554 : Room
{
public Room1554()
: base(1554, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 106, 122, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 287, 118, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 549, 129, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 578, 133, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 142, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 462, 143, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 524, 135, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 241, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 344, 147, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 178, 146, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 98, 143, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 515, 139, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 357, 203, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 485, 218, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 433, 221, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 254, 136, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 311, 242, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 599, 321, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 323, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 128, 239, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 379, 135, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 309, 132, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 287, 239, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 341, 225, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 329, 330, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 500, 211, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 165, 231, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 142, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 141, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 141, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 144, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 146, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 146, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 137, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 132, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 143, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 142, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 139, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 139, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 72, 226, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 271, 252, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 539, 223, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 440, 218, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 87, 222, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 65524, 243, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 54, 246, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 13, 229, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 81, 237, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 82, 241, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 97, 249, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 134, 253, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 387, 226, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 393, 297, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 438, 204, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 364, 246, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 389, 239, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 418, 247, 0, 1554));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 398, 255, 0, 1554));


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
