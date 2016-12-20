using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6801 : Room
{
public Room6801()
: base(6801, "Anything and Everything Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2013, 40, 1, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 143, 1, 8, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 232, 5, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 338, 3, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 461, 3, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 585, 3, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 280, 164, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 533, 213, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 621, 323, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 582, 333, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 583, 312, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 629, 204, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 234, 231, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2244, 143, 167, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 331, 231, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 115, 160, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2116, 507, 87, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2160, 291, 231, 18, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 279, 60, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2124, 281, 182, 21, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 534, 61, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 493, 76, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 117, 72, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 575, 76, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2107, 59, 299, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2136, 10, 315, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2145, 19, 301, 50, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2122, 282, 167, 66, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2159, 278, 167, 36, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(2128, 279, 65, 24, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 285, 178, 0, 6801));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 65525, 338, 0, 6801));



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
