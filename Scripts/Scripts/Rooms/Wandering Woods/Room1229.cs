using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1229 : Room
{
public Room1229()
: base(1229, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 372, 104, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 110, 122, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 98, 304, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 365, 41, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 124, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 673, 334, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 141, 306, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 96, 302, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 623, 194, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 559, 322, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 574, 203, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 564, 205, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 624, 206, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 615, 201, 0, 1229));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 590, 299, 0, 1229));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1223;
                case RoomExit.South: return 1235;
                case RoomExit.East:  return 4128;
                case RoomExit.West:  return 1228;
                default: return 0;
            }
        }
}
}
