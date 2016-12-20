using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10002 : Room
{
public Room10002()
: base(10002, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 568, 131, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 67, 132, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 24, 299, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 26, 326, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 117, 108, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 610, 113, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 336, 110, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 576, 131, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 409, 113, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 628, 135, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 209, 112, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 101, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 91, 113, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 454, 113, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 253, 119, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 597, 134, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 102, 328, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 9, 276, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 88, 123, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 568, 125, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 430, 116, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 233, 124, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 567, 133, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 72, 129, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 586, 271, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 640, 143, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 472, 278, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 263, 85, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 592, 74, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 106, 74, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65507, 71, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 80, 124, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 598, 134, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 423, 278, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 237, 124, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 614, 289, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 50, 220, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 99, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 186, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 295, 275, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 639, 320, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 517, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 529, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 541, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 553, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 565, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 577, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 589, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 600, 127, 0, 10002));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 614, 127, 0, 10002));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10010;
                case RoomExit.East:  return 10003;
                case RoomExit.West:  return 10001;
                default: return 0;
            }
        }
}
}
