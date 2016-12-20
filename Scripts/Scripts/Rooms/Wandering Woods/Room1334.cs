using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1334 : Room
{
public Room1334()
: base(1334, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 391, 134, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 579, 140, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 172, 139, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 16, 149, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 454, 149, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 267, 139, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 80, 135, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 482, 156, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 572, 199, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 624, 337, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 228, 247, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 186, 262, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 179, 132, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 153, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 506, 151, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 133, 240, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 524, 221, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 491, 154, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 543, 214, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 640, 327, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 46, 205, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 31, 211, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 134, 239, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 307, 246, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 238, 240, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 188, 258, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 158, 251, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 261, 253, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 215, 275, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 280, 254, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 522, 219, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 546, 229, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 428, 216, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 404, 225, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 293, 317, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 75, 332, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 40, 302, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 127, 309, 0, 1334));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 173, 315, 0, 1334));



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
