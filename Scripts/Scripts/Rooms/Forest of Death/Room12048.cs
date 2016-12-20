using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12048 : Room
{
public Room12048()
: base(12048, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 127, 121, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 492, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 486, 135, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 147, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 79, 140, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 196, 138, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 329, 142, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 270, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 529, 144, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 13, 217, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 436, 222, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 564, 255, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 506, 157, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 31, 214, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 388, 205, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 256, 177, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 65, 288, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 47, 219, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 311, 239, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 71, 211, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 0, 49, 436, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 277, 105, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(436, 222, 0, 115, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 622, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 224, 148, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 8, 109, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 14, 203, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 26, 329, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(40, 209, 0, 49, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 231, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 208, 205, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 45, 234, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 124, 286, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 19, 301, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 603, 278, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 442, 250, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 348, 239, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 292, 186, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 361, 278, 20, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 586, 243, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 36, 297, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 403, 218, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 265, 188, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 16, 201, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 490, 340, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 603, 329, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 65511, 349, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 221, 255, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 222, 209, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 178, 173, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 158, 137, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 166, 124, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 150, 116, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 205, 162, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 180, 220, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 202, 219, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 135, 107, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 114, 107, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 94, 108, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 108, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 54, 108, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 36, 109, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 20, 109, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 101, 138, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 138, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 138, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 127, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 127, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 330, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 140, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 139, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 143, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 197, 328, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 241, 328, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 281, 328, 0, 12048));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 158, 125, 0, 12048));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12043;
                case RoomExit.South: return 3103;
                case RoomExit.East:  return 12049;
                case RoomExit.West:  return 12047;
                default: return 0;
            }
        }
}
}
