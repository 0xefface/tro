using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1172 : Room
{
public Room1172()
: base(1172, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 524, 135, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 377, 136, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 623, 141, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 136, 138, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 574, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 20, 157, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 395, 135, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 142, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 147, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 518, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 327, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 451, 223, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 325, 252, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 271, 347, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 222, 231, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 205, 240, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 452, 215, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 64, 213, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 433, 219, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 142, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 41, 145, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 619, 131, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 266, 333, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 356, 307, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 306, 317, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 526, 332, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 331, 259, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 247, 243, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 405, 208, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 220, 234, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 136, 254, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 49, 254, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 20, 261, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 329, 318, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 40, 205, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 454, 229, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 306, 224, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 438, 216, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 208, 319, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 66, 313, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 139, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 139, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 139, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 533, 316, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 614, 326, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 139, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 137, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 137, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 141, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 14, 156, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 131, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 140, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 133, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 133, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 146, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 146, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 275, 126, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 268, 127, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 269, 124, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 316, 173, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 271, 147, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 326, 171, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 378, 227, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 410, 227, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 380, 203, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 418, 216, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 298, 246, 0, 1172));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 281, 229, 0, 1172));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1166;
                case RoomExit.South: return 1178;
                case RoomExit.East:  return 1173;
                case RoomExit.West:  return 1171;
                default: return 0;
            }
        }
}
}
