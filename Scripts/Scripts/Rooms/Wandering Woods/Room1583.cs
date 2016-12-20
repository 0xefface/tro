using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1583 : Room
{
public Room1583()
: base(1583, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 226, 133, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 439, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 243, 134, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 139, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 93, 140, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 417, 155, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 148, 147, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 43, 124, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 536, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 616, 136, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 349, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 469, 146, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 155, 251, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 608, 257, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 231, 328, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 228, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 223, 237, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 39, 209, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 435, 222, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 167, 253, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 401, 217, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 309, 249, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 121, 249, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 451, 218, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 106, 254, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 484, 231, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 600, 269, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 305, 327, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 390, 218, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 158, 243, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 255, 245, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 87, 215, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 265, 236, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 140, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 121, 140, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 140, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 123, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 131, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 133, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 133, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 133, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 137, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 147, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 146, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 138, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(134, 276, 234, 0, 1583));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 65513, 238, 0, 1583));



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
