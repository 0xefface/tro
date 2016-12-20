using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6803 : Room
{
public Room6803()
: base(6803, "Arimathor Armory Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 183, 2, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 389, 16, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(34989, 49, 172, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 81, 8, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 477, 25, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 474, 77, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 429, 183, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 433, 184, 63, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2120, 428, 183, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 141, 291, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 279, 291, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 142, 292, 5, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 283, 292, 60, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 140, 292, 34, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 289, 292, 4, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 599, 182, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 287, 7, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 591, 41, 20, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(34907, 652, 183, 65521, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(34905, 650, 183, 13, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2106, 181, 185, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 148, 115, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 564, 135, 0, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 183, 116, 16, 6803));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 617, 137, 12, 6803));



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
