using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1690 : Room
{
public Room1690()
: base(1690, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 340, 132, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 549, 129, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 134, 132, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 448, 140, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 147, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 137, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 205, 138, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 513, 144, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 578, 149, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 326, 141, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 143, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 21, 139, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 596, 276, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 46, 266, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 320, 262, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 384, 248, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 313, 260, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 197, 221, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 0, 156, 326, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 143, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 140, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 136, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 136, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 136, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 137, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 136, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 143, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 424, 141, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 140, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 139, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 143, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 150, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 143, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 65521, 319, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 386, 252, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 22, 264, 0, 1690));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 636, 277, 0, 1690));



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
