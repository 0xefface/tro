using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1279 : Room
{
public Room1279()
: base(1279, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 535, 139, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 143, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 177, 140, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 358, 145, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 489, 146, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 138, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 68, 140, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 450, 140, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 405, 140, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 123, 141, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 136, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 611, 318, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 448, 269, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 229, 220, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 330, 248, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 409, 258, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 257, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 234, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 491, 237, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 139, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 267, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 255, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 234, 225, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 352, 257, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 431, 272, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 344, 257, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 395, 256, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 487, 236, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 517, 246, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 363, 241, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 614, 332, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 141, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 136, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 138, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 144, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 140, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 139, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 139, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 142, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 693, 301, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 676, 356, 0, 1279));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 651, 306, 0, 1279));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
