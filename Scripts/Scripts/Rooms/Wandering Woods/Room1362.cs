using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1362 : Room
{
public Room1362()
: base(1362, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65504, 124, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 566, 135, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 531, 137, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 586, 145, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 242, 142, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 390, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 51, 142, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 302, 143, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 102, 137, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 137, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 586, 323, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 264, 297, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 519, 319, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 398, 223, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 336, 219, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 468, 219, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 31, 257, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 133, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 362, 326, 65516, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 267, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 119, 209, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 133, 230, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 110, 220, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 268, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 256, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 351, 266, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 246, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 428, 269, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 417, 249, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 497, 247, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 475, 237, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 618, 329, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 566, 324, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 264, 328, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 238, 316, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 351, 333, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 179, 330, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 137, 213, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 365, 220, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 92, 213, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 139, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 115, 323, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 541, 311, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 529, 315, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 229, 343, 20, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 248, 327, 20, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 427, 327, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 362, 218, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 136, 326, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 216, 302, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 408, 313, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 314, 304, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 112, 207, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 144, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 413, 435, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 392, 166, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 141, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 141, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 138, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 136, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 142, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 142, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 141, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 141, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 140, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 63, 210, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 310, 290, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 217, 216, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(32978, 364, 217, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 497, 218, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 310, 290, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 299, 343, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 413, 218, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 620, 220, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 408, 353, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 220, 215, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 567, 253, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 145, 252, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 162, 235, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 25, 248, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 311, 249, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 308, 263, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 438, 247, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 435, 268, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 540, 208, 0, 1362));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 655, 257, 0, 1362));



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
