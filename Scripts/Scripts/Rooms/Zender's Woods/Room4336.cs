using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4336 : Room
{
public Room4336()
: base(4336, "Zender's Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 535, 139, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 143, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 177, 140, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 358, 145, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 489, 146, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 138, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 68, 140, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 450, 140, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 405, 140, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 123, 141, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 136, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 611, 318, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 448, 269, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 229, 220, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 409, 258, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 257, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 234, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 491, 237, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 139, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 431, 272, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 344, 257, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 487, 236, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 363, 241, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 141, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 136, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 138, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 144, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 140, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 139, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 139, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 142, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 235, 223, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 51, 255, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 219, 226, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 203, 219, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 369, 207, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 352, 197, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 510, 195, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 574, 196, 0, 4336));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 46, 95, 0, 4336));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4335;
                case RoomExit.South: return 16001;
                case RoomExit.East:  return 4325;
                case RoomExit.West:  return 1379;
                default: return 0;
            }
        }
}
}
