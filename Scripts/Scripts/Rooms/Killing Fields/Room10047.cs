using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10047 : Room
{
public Room10047()
: base(10047, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(44, 424, 222, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 566, 139, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 589, 107, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 83, 249, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 327, 206, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 452, 265, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 95, 268, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 595, 206, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1061, 608, 323, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 5, 105, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 9, 117, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 640, 323, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32829, 609, 245, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 596, 224, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 590, 260, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 24, 117, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 110, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 58, 264, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 524, 114, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 526, 196, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 124, 326, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 410, 111, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 176, 193, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 454, 124, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 12, 113, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 47, 117, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 11, 122, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 529, 124, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 552, 328, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 34, 106, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65405, 106, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 27, 120, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 386, 276, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 104, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 374, 107, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(106, 65510, 254, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 372, 108, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 400, 110, 0, 10047));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 64, 106, 0, 10047));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10039;
                case RoomExit.South: return 12001;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10046;
                default: return 0;
            }
        }
}
}
