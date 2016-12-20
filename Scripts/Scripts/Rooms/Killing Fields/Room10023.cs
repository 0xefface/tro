using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10023 : Room
{
public Room10023()
: base(10023, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 633, 318, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 566, 139, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 589, 107, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 83, 249, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 168, 268, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 288, 275, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 95, 268, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 254, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1061, 619, 323, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 99, 110, 7, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 28, 116, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 12, 214, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32829, 623, 267, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 66, 206, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 16, 219, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 656, 290, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 15, 119, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 393, 109, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 528, 114, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 573, 228, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 19, 106, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 528, 126, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 572, 137, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 392, 196, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 26, 235, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65438, 105, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 530, 127, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 468, 269, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 328, 104, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 101, 112, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 65506, 280, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 30, 235, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 46, 236, 0, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 608, 107, 27, 10023));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 369, 110, 5, 10023));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10015;
                case RoomExit.South: return 10031;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10022;
                default: return 0;
            }
        }
}
}
