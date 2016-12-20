using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1395 : Room
{
public Room1395()
: base(1395, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 317, 102, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 37, 316, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 353, 209, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 386, 212, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 129, 254, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 1, 309, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 309, 165, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 14, 158, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 354, 208, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 558, 228, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 109, 249, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 602, 223, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 607, 106, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 55, 155, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 596, 226, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 141, 317, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 351, 211, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 25, 154, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 198, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 59, 250, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(142, 414, 104, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 534, 103, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(33010, 760, 95, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(142, 397, 105, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 98, 195, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 3, 308, 0, 1395));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 65526, 240, 0, 1395));



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
