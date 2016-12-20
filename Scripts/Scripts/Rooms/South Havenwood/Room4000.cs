using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4000 : Room
{
public Room4000()
: base(4000, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 507, 105, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 126, 106, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 293, 106, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 150, 233, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 189, 294, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 193, 301, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 155, 234, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 583, 249, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 85, 114, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 617, 117, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 16, 352, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 83, 172, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 410, 191, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 239, 178, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 320, 185, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 638, 200, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 4, 168, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 153, 173, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 565, 112, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(197, 393, 49, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(198, 70, 52, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 540, 197, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 101, 294, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 324, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 46, 239, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 96, 304, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 16, 303, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 75, 304, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 33, 304, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 55, 304, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 6, 238, 0, 4000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 31, 256, 0, 4000));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5075;
                case RoomExit.South: return 4015;
                case RoomExit.East:  return 4001;
                case RoomExit.West:  return 1047;
                default: return 0;
            }
        }
}
}
