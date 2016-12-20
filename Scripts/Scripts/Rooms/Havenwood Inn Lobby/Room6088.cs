using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6088 : Room
{
public Room6088()
: base(6088, "Havenwood Inn Lobby")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2600, 171, 306, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(34989, 41, 159, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 150, 1, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 491, 1, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 252, 11, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 375, 11, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2001, 594, 6, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 599, 17, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 597, 122, 65486, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 493, 4, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 493, 109, 65486, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 404, 54, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 318, 54, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 152, 3, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 232, 54, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 399, 109, 65486, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 153, 159, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 312, 159, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 240, 159, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 141, 186, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 232, 197, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 337, 187, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(35012, 634, 382, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(35012, 629, 358, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 392, 201, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 477, 274, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 168, 80, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 166, 111, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 302, 81, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2122, 301, 113, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2124, 160, 200, 70, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 394, 156, 50, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 501, 109, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 415, 109, 0, 6088));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 480, 156, 50, 6088));



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
