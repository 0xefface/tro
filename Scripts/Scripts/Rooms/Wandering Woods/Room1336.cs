using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1336 : Room
{
public Room1336()
: base(1336, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 74, 123, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 546, 120, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 327, 127, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 437, 137, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 143, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 44, 122, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 542, 141, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 389, 133, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 321, 138, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 71, 169, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 395, 141, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 530, 131, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 257, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 229, 321, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 622, 321, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 86, 256, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 73, 182, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 96, 188, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 65530, 163, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 199, 269, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 349, 234, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 46, 190, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 607, 302, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 0, 221, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 38, 223, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 2, 203, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 518, 334, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 497, 257, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 482, 284, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 482, 289, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 107, 199, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 633, 333, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 539, 250, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 173, 228, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 49, 290, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 287, 256, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 502, 283, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 419, 293, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 400, 294, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 539, 291, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 482, 290, 20, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 429, 306, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 360, 237, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 67, 218, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 275, 327, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 156, 240, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 432, 134, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 135, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 413, 140, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 133, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 130, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 141, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 141, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 561, 141, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 139, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 79, 123, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 61, 123, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 42, 122, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 132, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 140, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 137, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 137, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 140, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 258, 125, 0, 1336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 137, 0, 1336));



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
