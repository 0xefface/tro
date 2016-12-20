using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1392 : Room
{
public Room1392()
: base(1392, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 22, 137, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 176, 132, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 552, 127, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 569, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 212, 140, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 629, 143, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 479, 144, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 75, 138, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 303, 142, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 520, 140, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 437, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 11, 139, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 353, 138, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 323, 225, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 426, 276, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 99, 214, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 544, 270, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 469, 273, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 334, 241, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 324, 127, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 87, 217, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 37, 213, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 582, 223, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 127, 215, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 357, 242, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 615, 225, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 60, 211, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 137, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 142, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 139, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 142, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 138, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 143, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 440, 141, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 144, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 503, 284, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 50, 233, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 207, 237, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 307, 221, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 328, 305, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 243, 319, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 165, 216, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 272, 238, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 319, 232, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 194, 286, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 468, 273, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 279, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 302, 279, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 77, 255, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 64, 235, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 608, 166, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 555, 255, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 616, 322, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 574, 214, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 5, 249, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 348, 336, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 273, 230, 0, 1392));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 232, 240, 0, 1392));


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
