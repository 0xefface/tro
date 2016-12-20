using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12047 : Room
{
public Room12047()
: base(12047, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65504, 124, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 566, 135, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 531, 137, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 586, 145, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 242, 142, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 390, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 51, 142, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 302, 143, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 102, 137, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 137, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 616, 319, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 264, 297, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 419, 251, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 334, 248, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 478, 238, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 31, 257, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 133, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 362, 326, 65516, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 267, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 120, 219, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 236, 326, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 133, 230, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 110, 220, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 268, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 256, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 351, 266, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 246, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 428, 269, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 417, 249, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 497, 247, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 475, 237, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 618, 329, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 566, 324, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 264, 328, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 238, 316, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 351, 333, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 179, 330, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 157, 238, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 532, 246, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 469, 265, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 187, 309, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 115, 323, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 583, 306, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 524, 319, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 226, 328, 20, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 252, 314, 20, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 427, 327, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 364, 240, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 134, 320, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 216, 302, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 408, 317, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 314, 304, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 127, 219, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 29, 343, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 588, 348, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 430, 388, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 246, 384, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 392, 166, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 141, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 141, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 138, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 136, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 142, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 142, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 141, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 141, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 140, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 139, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 144, 0, 12047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 12047));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12042;
                case RoomExit.South: return 3102;
                case RoomExit.East:  return 12048;
                case RoomExit.West:  return 12046;
                default: return 0;
            }
        }
}
}
