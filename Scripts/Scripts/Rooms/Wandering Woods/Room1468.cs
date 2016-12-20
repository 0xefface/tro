using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1468 : Room
{
public Room1468()
: base(1468, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 456, 139, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 149, 141, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 309, 140, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 141, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 523, 142, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 306, 316, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 304, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 371, 247, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 309, 321, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 331, 246, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 243, 207, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 371, 233, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 382, 242, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 283, 318, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 63, 320, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 102, 212, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 415, 302, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 0, 156, 28, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 262, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 133, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 140, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 140, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 124, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 139, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 139, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 142, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 388, 141, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 141, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 139, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 143, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 142, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 142, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 89, 225, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(32982, 222, 224, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 369, 189, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 249, 191, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(33707, 481, 300, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(947, 568, 248, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(33712, 463, 328, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 595, 243, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 272, 248, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 361, 224, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 171, 217, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 223, 264, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 14, 257, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 583, 498, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 75, 260, 0, 1468));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 468, 498, 0, 1468));



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
