using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1539 : Room
{
public Room1539()
: base(1539, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 140, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 137, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 378, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 144, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 157, 139, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 532, 148, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 61, 129, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 303, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 228, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 484, 144, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 97, 135, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 479, 204, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 545, 269, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 397, 245, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 351, 214, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 399, 203, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 520, 216, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 152, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 590, 257, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 573, 118, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 178, 107, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 368, 118, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 226, 133, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 134, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 17, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 627, 153, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 537, 267, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 217, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 65535, 243, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 74, 213, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 473, 245, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 135, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 133, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 133, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 131, 139, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 145, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 214, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 142, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 143, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 146, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 146, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 562, 251, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 543, 251, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65528, 320, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 651, 323, 0, 1539));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 691, 280, 0, 1539));



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
