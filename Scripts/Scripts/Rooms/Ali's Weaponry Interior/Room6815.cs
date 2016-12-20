using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6815 : Room
{
public Room6815()
: base(6815, "Ali's Weaponry Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 183, 2, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 389, 16, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(34989, 49, 172, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 81, 8, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 477, 25, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 181, 66, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2106, 181, 185, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(34905, 650, 183, 13, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(34907, 652, 183, 65521, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 141, 291, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 279, 291, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 142, 292, 5, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 283, 292, 60, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 140, 292, 34, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2121, 289, 292, 4, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 599, 182, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 287, 7, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 591, 41, 20, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2048, 250, 151, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2049, 454, 151, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 494, 124, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 304, 123, 0, 6815));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 598, 85, 0, 6815));



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
