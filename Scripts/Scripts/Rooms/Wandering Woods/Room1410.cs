using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1410 : Room
{
public Room1410()
: base(1410, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 116, 135, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 275, 115, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 35, 321, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 518, 219, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 546, 318, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 480, 220, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 11, 341, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 467, 218, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 170, 142, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 365, 145, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 464, 144, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 340, 146, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 368, 146, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 386, 146, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 347, 141, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 369, 140, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 140, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 435, 144, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 434, 139, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 129, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 129, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 144, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 144, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 144, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 133, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 135, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 131, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 132, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 131, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 523, 226, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 117, 134, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65532, 323, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 64, 225, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 108, 37, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 119, 141, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 130, 103, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 82, 124, 0, 1410));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 37, 326, 0, 1410));



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
