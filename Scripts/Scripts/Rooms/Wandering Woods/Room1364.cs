using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1364 : Room
{
public Room1364()
: base(1364, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 540, 133, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 147, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 163, 136, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 561, 142, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 503, 139, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 12, 148, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 146, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 467, 129, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 476, 145, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 224, 253, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 242, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 240, 210, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 491, 237, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 613, 209, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 189, 220, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 147, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 33, 219, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 187, 228, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 64, 240, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 624, 134, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 420, 115, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 636, 156, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 139, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 248, 220, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 329, 183, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 387, 106, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 421, 109, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 406, 112, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 140, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 141, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 141, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 149, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 140, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(937, 330, 182, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(936, 391, 122, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(33702, 239, 135, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(950, 255, 181, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 195, 134, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 133, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 176, 191, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 322, 104, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 305, 121, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 330, 141, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 257, 116, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 607, 93, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 555, 111, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 319, 190, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 225, 186, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 204, 184, 0, 1364));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 187, 179, 0, 1364));



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
