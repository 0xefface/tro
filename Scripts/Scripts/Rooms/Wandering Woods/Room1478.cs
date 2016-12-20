using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1478 : Room
{
public Room1478()
: base(1478, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 524, 135, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 363, 138, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 623, 141, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 136, 138, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 574, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 20, 157, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 260, 142, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 518, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 327, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 438, 226, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 363, 323, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 312, 231, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 222, 231, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 148, 253, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 46, 217, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 480, 229, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 64, 213, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 431, 226, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 142, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 41, 145, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 619, 131, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 266, 333, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 356, 307, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 306, 317, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 526, 332, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 331, 259, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 247, 243, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 296, 279, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 220, 234, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 136, 254, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 49, 254, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 20, 261, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 409, 304, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 40, 205, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 454, 229, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 285, 213, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 438, 216, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 208, 319, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 66, 313, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 139, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 139, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 139, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 140, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 517, 296, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 612, 325, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 139, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 137, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 137, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 141, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 14, 156, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 131, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 141, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 142, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 138, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 138, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 146, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 146, 0, 1478));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 65525, 209, 0, 1478));



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
