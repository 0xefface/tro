using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10031 : Room
{
public Room10031()
: base(10031, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 568, 131, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 67, 132, 65534, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 594, 334, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 632, 283, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 444, 113, 13, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 220, 114, 10, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 185, 116, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 554, 126, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 3, 220, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 90, 118, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 28, 134, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 521, 121, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 596, 187, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 191, 330, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 16, 107, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 442, 108, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 312, 292, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 517, 115, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 95, 304, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 204, 112, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 324, 104, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 232, 110, 2, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 431, 108, 5, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 49, 135, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 123, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 123, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 123, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 123, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 128, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 128, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 128, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 117, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 120, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 128, 0, 10031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 128, 0, 10031));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10023;
                case RoomExit.South: return 10039;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10030;
                default: return 0;
            }
        }
}
}
