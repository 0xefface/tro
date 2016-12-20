using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1501 : Room
{
public Room1501()
: base(1501, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 504, 127, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 664, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 468, 207, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 17, 153, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 371, 143, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 61, 146, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 288, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 269, 325, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 298, 321, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 612, 255, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 428, 220, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 552, 320, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 238, 195, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 21, 226, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 191, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 179, 328, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 141, 226, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 299, 218, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 196, 218, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 613, 316, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 135, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 138, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 135, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 44, 225, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 30, 300, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 26, 200, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 0, 300, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 323, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 136, 328, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 48, 201, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 208, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 221, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 563, 333, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 304, 261, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 225, 257, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 208, 251, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 270, 197, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 199, 191, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 445, 228, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 191, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65, 200, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 616, 338, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 503, 133, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 46, 145, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 144, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 270, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 142, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 139, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32814, 467, 210, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 31, 217, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(205, 630, 107, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 525, 173, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 497, 188, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(217, 604, 126, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 544, 162, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 123, 251, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 126, 261, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 257, 251, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 261, 262, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 488, 223, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 526, 199, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 563, 172, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 613, 130, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 370, 207, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 367, 259, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 409, 255, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 20, 255, 0, 1501));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 614, 122, 0, 1501));



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
