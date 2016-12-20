using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1332 : Room
{
public Room1332()
: base(1332, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 140, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 137, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 378, 143, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 144, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 186, 140, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 532, 148, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 61, 129, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 303, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 228, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 484, 144, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 84, 136, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 40, 209, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 443, 251, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 545, 269, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 366, 257, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 236, 231, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 329, 254, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 127, 197, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 562, 267, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 573, 118, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 178, 107, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 368, 118, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 226, 133, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 134, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 13, 145, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 627, 153, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 197, 244, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 187, 247, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 0, 48, 40, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 48, 214, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 450, 257, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 135, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 133, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 133, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 139, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 145, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 214, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 143, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 143, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 143, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 143, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 146, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 146, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 219, 233, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 201, 233, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 152, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 138, 116, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 131, 142, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 132, 120, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 138, 165, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 132, 202, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 120, 240, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 93, 261, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 468, 254, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 596, 138, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 174, 251, 0, 1332));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 563, 220, 0, 1332));



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
