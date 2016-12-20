using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1531 : Room
{
public Room1531()
: base(1531, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 340, 132, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 549, 129, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 134, 132, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 448, 140, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 608, 147, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 137, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 205, 138, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 513, 144, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 578, 149, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 326, 141, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 143, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 21, 139, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 41, 258, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 599, 208, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 46, 266, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 227, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 480, 237, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 203, 219, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 197, 221, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 0, 156, 326, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 143, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 140, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 136, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 136, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 136, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 137, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 136, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 143, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 424, 141, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 140, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 139, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 143, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 150, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 143, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 107, 333, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(32829, 177, 225, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 648, 309, 0, 1531));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 651, 246, 0, 1531));



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
