using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1658 : Room
{
public Room1658()
: base(1658, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 150, 140, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 15, 305, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 584, 249, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 251, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 405, 299, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 565, 250, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 272, 248, 65526, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 356, 319, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 35, 322, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 72, 321, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 262, 257, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 207, 191, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 354, 307, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 139, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 146, 139, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 139, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 129, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 129, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 278, 144, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 126, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 314, 144, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 142, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 141, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 141, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 138, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 137, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 137, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 144, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 144, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 143, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 130, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 569, 209, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 25, 204, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 411, 225, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 408, 216, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 180, 230, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 191, 223, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 286, 258, 0, 1658));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 654, 306, 65526, 1658));



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
