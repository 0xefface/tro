using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1316 : Room
{
public Room1316()
: base(1316, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 340, 132, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 549, 129, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 134, 132, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 448, 140, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 146, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 137, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 205, 138, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 513, 144, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 578, 149, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 326, 141, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 21, 139, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 523, 270, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 46, 266, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 227, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 548, 267, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 203, 219, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 197, 221, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 0, 156, 326, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 140, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 136, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 136, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 136, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 137, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 136, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 424, 141, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 140, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 139, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 150, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(33002, 236, 111, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 243, 138, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 242, 115, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 243, 161, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 258, 208, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 273, 234, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 299, 234, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 274, 198, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 251, 163, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(33000, 253, 143, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 227, 220, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 539, 275, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 177, 219, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 235, 317, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 522, 253, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 623, 155, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 617, 144, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 653, 340, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 647, 221, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 450, 315, 0, 1316));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 564, 264, 0, 1316));



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
