using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6029 : Room
{
public Room6029()
: base(6029, "East Leinster Chapel Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2004, 567, 5, 55, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 294, 4, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 420, 4, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2026, 172, 3, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 509, 2, 7, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2025, 148, 2, 8, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2016, 94, 4, 55, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 163, 61, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 289, 55, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 424, 58, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 573, 126, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 195, 126, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 324, 124, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 458, 124, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 303, 133, 10, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 436, 136, 10, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 174, 134, 10, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 456, 63, 20, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 323, 64, 20, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 195, 67, 20, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2557, 625, 136, 20, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 274, 62, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 376, 61, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 525, 80, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 407, 94, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 247, 94, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 131, 74, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 325, 295, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2049, 155, 73, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2085, 195, 127, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2049, 283, 71, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2085, 324, 125, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2049, 417, 71, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2085, 457, 126, 0, 6029));
this.AddRoomDecoration(RoomDecoration.FromCode(2048, 571, 144, 0, 6029));


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
