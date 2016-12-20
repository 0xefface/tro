using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1302 : Room
{
public Room1302()
: base(1302, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65530, 123, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 546, 126, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 393, 129, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 602, 143, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 84, 146, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 205, 144, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 283, 142, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 246, 209, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 386, 133, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 17, 128, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 332, 141, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 607, 314, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 400, 244, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 602, 321, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 251, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 462, 256, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 198, 235, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 257, 235, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 210, 140, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 414, 235, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 477, 247, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 332, 257, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 421, 259, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 258, 233, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 279, 243, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 354, 264, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 187, 248, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 460, 258, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 391, 243, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 154, 222, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 176, 237, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 135, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 142, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 141, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 33, 278, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65431, 228, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 456, 255, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 138, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 144, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 140, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(61, 133, 240, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 128, 134, 10, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 132, 243, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 138, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 308, 143, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 133, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 142, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 134, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 139, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 142, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 208, 236, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 185, 242, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 38, 240, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 391, 266, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 560, 261, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 567, 323, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 651, 312, 0, 1302));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 65500, 315, 0, 1302));



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
