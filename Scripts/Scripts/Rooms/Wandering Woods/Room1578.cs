using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1578 : Room
{
public Room1578()
: base(1578, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 348, 139, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 133, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 131, 137, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 145, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 331, 149, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 140, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 507, 156, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 422, 143, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 203, 142, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 140, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 460, 147, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 127, 142, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 77, 145, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 431, 326, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 303, 319, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 54, 257, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 119, 227, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 605, 207, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 475, 255, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 324, 246, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 110, 111, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 477, 138, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 264, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 128, 228, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 259, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 145, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 164, 144, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 310, 310, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 310, 310, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 454, 324, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 310, 310, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 310, 310, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 310, 310, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 144, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 143, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 144, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 146, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 144, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 142, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 148, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 149, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 142, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 141, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 156, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 156, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 146, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 146, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65510, 259, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 634, 205, 0, 1578));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 612, 208, 0, 1578));



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
