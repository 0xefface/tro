using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10015 : Room
{
public Room10015()
: base(10015, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 533, 108, 65516, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 19, 121, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 594, 223, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 546, 199, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 530, 111, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 632, 357, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 555, 199, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32828, 594, 242, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 579, 171, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 570, 246, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 495, 126, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 526, 158, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 97, 106, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 375, 105, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 60, 125, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 373, 107, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 98, 107, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 124, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 450, 132, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 470, 134, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 511, 167, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 562, 140, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 38, 110, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 407, 111, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 476, 161, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 53, 128, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 382, 105, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 494, 108, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 194, 300, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 74, 106, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 244, 195, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 285, 205, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 326, 104, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 21, 127, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 119, 107, 0, 10015));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 421, 133, 0, 10015));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10007;
                case RoomExit.South: return 10023;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10014;
                default: return 0;
            }
        }
}
}
