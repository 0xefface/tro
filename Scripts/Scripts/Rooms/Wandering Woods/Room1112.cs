using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1112 : Room
{
public Room1112()
: base(1112, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 451, 102, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 445, 103, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 54, 102, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 264, 102, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 471, 209, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 168, 263, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 629, 42, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 174, 262, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 17, 324, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 485, 230, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 159, 248, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 25, 324, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 443, 219, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 436, 213, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 481, 213, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 133, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 136, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 135, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 137, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 137, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 130, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 130, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 130, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 130, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 122, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 266, 226, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 202, 210, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 175, 211, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 195, 261, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 206, 253, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 136, 258, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 569, 181, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 437, 182, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 320, 188, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 304, 185, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 472, 184, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 601, 186, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 316, 201, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 336, 193, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 575, 214, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 412, 223, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 259, 210, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 58, 212, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 395, 183, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 519, 182, 0, 1112));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 603, 181, 0, 1112));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22046;
                case RoomExit.South: return 1119;
                case RoomExit.East:  return 1113;
                case RoomExit.West:  return 22049;
                default: return 0;
            }
        }
}
}
