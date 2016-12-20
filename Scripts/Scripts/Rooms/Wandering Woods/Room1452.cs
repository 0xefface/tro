using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1452 : Room
{
public Room1452()
: base(1452, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 532, 133, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 379, 132, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 203, 134, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 561, 142, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 503, 139, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 12, 148, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 146, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 442, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 404, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 351, 328, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 82, 266, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 329, 247, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 406, 260, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 222, 222, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 605, 211, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 32, 257, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 133, 245, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 124, 223, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 624, 134, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 257, 134, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 636, 156, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 139, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 269, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 27, 255, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 147, 237, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 319, 245, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 417, 261, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 395, 243, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 616, 221, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 240, 229, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 104, 225, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 264, 224, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 345, 261, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 365, 240, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 78, 229, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 296, 244, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 141, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 141, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 421, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 140, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 323, 141, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 141, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 134, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 195, 134, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 133, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 147, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 147, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 149, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 651, 202, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 413, 265, 0, 1452));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 645, 212, 0, 1452));



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
