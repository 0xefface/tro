using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1236 : Room
{
public Room1236()
: base(1236, "Despothes's Temple")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(202, 75, 142, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 92, 139, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 96, 142, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 20, 301, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 131, 230, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 42, 239, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 103, 259, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 15, 106, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2339, 514, 128, 16, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2339, 610, 127, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2339, 707, 128, 65522, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 451, 127, 65392, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 519, 124, 65399, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 584, 120, 65405, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(35078, 621, 307, 65491, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 65511, 90, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 60, 151, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 525, 109, 65460, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 182, 223, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 29, 223, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 559, 105, 65407, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 248, 196, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 269, 195, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 405, 113, 65470, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 25, 246, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 123, 142, 65470, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 281, 168, 65418, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 103, 45, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 33, 343, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 266, 36, 65532, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 415, 105, 21, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 6, 108, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 153, 89, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 149, 216, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 620, 321, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 474, 115, 65412, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 481, 116, 65411, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 42, 359, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 499, 116, 65401, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 451, 119, 65376, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 258, 180, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 30, 301, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32932, 445, 46, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2355, 477, 189, 108, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 521, 110, 65376, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2315, 620, 122, 65349, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 584, 100, 65376, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 451, 179, 69, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 624, 174, 36, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2393, 604, 226, 93, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 469, 191, 78, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2393, 552, 270, 145, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2391, 469, 244, 203, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2393, 555, 312, 258, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2393, 602, 251, 190, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2356, 477, 222, 149, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2355, 637, 251, 148, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2356, 559, 242, 159, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2356, 637, 289, 195, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2355, 559, 204, 112, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2355, 477, 128, 166, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 419, 301, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 501, 288, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 583, 344, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 8, 14, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 310, 290, 65466, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 381, 96, 31, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 191, 125, 65470, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 277, 244, 0, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 304, 107, 65436, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 309, 131, 65436, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 100, 133, 65436, 1236));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 173, 159, 65436, 1236));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1230;
                case RoomExit.South: return 1242;
                case RoomExit.East:  return 1237;
                case RoomExit.West:  return 1279;
                default: return 0;
            }
        }
}
}
