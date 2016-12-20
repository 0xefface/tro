using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1676 : Room
{
public Room1676()
: base(1676, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 557, 129, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 308, 129, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 416, 144, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 599, 144, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 536, 142, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 138, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 136, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 212, 143, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 501, 135, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 348, 238, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 511, 323, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 627, 280, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 363, 350, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 179, 222, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 122, 320, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 156, 242, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 311, 197, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 13, 320, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 371, 67, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 442, 117, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 137, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 142, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 235, 144, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 143, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 99, 224, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 169, 314, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 594, 203, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 134, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 143, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 143, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 144, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 211, 144, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 136, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 136, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 136, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 146, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 146, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 146, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 136, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 590, 203, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 471, 204, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 334, 217, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 311, 211, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 229, 245, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 258, 244, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 306, 246, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 341, 258, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 392, 248, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(134, 344, 250, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 261, 211, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 294, 211, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 262, 210, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 638, 331, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 145, 241, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 656, 239, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 75, 137, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 75, 137, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 7, 220, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65495, 294, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 78, 107, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 62, 151, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 36, 131, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 88, 39, 0, 1676));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 32, 313, 0, 1676));



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
