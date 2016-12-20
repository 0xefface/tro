using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1363 : Room
{
public Room1363()
: base(1363, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65498, 121, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 296, 131, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 383, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 560, 142, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 130, 137, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 277, 142, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 324, 141, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 521, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 195, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 131, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 250, 308, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 120, 298, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 313, 245, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 208, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 228, 237, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 165, 239, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 382, 112, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 90, 214, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 541, 217, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 140, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 274, 333, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 119, 336, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65516, 216, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(133, 0, 156, 28, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 302, 252, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 228, 236, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 159, 238, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 251, 241, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 43, 203, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 229, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 350, 201, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 538, 216, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 553, 225, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 69, 326, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 116, 313, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 15, 316, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 61, 334, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 176, 322, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 185, 235, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 9, 201, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 290, 236, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 136, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 136, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 77, 132, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 180, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 141, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 141, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 130, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 131, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 139, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 427, 96, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32989, 450, 186, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 452, 128, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 408, 228, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 480, 229, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 224, 241, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 67, 241, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 134, 244, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 294, 240, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 341, 245, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 398, 210, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 548, 213, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 527, 221, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 571, 220, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 504, 213, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 540, 203, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 565, 208, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 154, 290, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 160, 271, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 311, 294, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 318, 272, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 440, 241, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 451, 133, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 360, 185, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 546, 189, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 21, 282, 0, 1363));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 445, 123, 0, 1363));



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
