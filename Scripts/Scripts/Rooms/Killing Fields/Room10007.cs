using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10007 : Room
{
public Room10007()
: base(10007, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.UpRight;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 522, 115, 65516, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 20, 132, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 635, 325, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 583, 208, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 625, 225, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 25, 117, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(151, 310, 142, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(150, 144, 120, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 447, 130, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 12, 136, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 633, 223, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 411, 132, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 14, 189, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 429, 288, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 256, 143, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 282, 324, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 532, 217, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 3, 275, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 56, 127, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 444, 133, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 524, 205, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 40, 186, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 34, 131, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 56, 141, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 428, 302, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 6, 273, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 102, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 77, 131, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 125, 121, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 437, 187, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 454, 200, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 425, 207, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 418, 195, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 448, 209, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 417, 200, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 464, 193, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 435, 210, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 449, 198, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 425, 201, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 249, 137, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 267, 137, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 284, 137, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 302, 137, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 320, 137, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 3, 130, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 15, 130, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 27, 130, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 39, 130, 0, 10007));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 51, 130, 0, 10007));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10015;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10006;
                default: return 0;
            }
        }
}
}
