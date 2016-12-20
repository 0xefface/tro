using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10004 : Room
{
public Room10004()
: base(10004, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 527, 115, 65516, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 20, 132, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 241, 262, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 25, 117, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(151, 310, 142, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(150, 144, 120, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 447, 130, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 632, 259, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 613, 114, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 200, 265, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 528, 133, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 120, 124, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 560, 137, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 23, 124, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 591, 329, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 48, 134, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 620, 269, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 440, 132, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 52, 218, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 533, 105, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 493, 74, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 608, 271, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 426, 271, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 82, 121, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 110, 239, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 103, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 587, 125, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 564, 132, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 404, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 421, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 439, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 457, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 475, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 492, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 510, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 528, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 546, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 563, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 580, 126, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 49, 128, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 37, 128, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 26, 128, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 14, 128, 0, 10004));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 2, 128, 0, 10004));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10012;
                case RoomExit.East:  return 10005;
                case RoomExit.West:  return 10003;
                default: return 0;
            }
        }
}
}
