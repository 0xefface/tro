using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6014 : Room
{
public Room6014()
: base(6014, "To The Hilt Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 183, 2, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 389, 16, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(34989, 49, 172, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 81, 8, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 477, 25, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 474, 77, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 429, 183, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 433, 184, 63, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2120, 428, 183, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 141, 291, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 279, 291, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 142, 292, 5, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 283, 292, 60, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 140, 292, 34, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 289, 292, 4, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 599, 182, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 287, 7, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 591, 41, 20, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(34907, 652, 183, 65521, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(34905, 650, 183, 13, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2081, 619, 97, 65516, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 385, 84, 65516, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 583, 111, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 364, 101, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 182, 96, 65526, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 161, 103, 0, 6014));
this.AddRoomDecoration(RoomDecoration.FromCode(2106, 181, 185, 0, 6014));



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
