using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1272 : Room
{
public Room1272()
: base(1272, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 127, 121, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 492, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 486, 135, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 147, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 79, 140, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 196, 138, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 329, 142, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 270, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 529, 144, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 13, 217, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 437, 218, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 567, 260, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 506, 157, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 37, 202, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 388, 205, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 256, 177, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 565, 219, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 588, 258, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 103, 211, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 418, 220, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 74, 206, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 0, 49, 436, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 277, 105, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(436, 222, 0, 115, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 622, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 224, 148, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 8, 109, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 14, 203, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 26, 329, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(40, 209, 0, 49, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 231, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 208, 205, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 45, 234, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 124, 286, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 19, 301, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 603, 278, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 442, 250, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 348, 239, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 292, 186, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 361, 278, 20, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 586, 243, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 36, 297, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 403, 216, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 265, 188, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 16, 201, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 138, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 138, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 127, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 127, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 330, 143, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 140, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 139, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 135, 107, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 114, 107, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 94, 108, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 108, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 54, 108, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 36, 109, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 20, 109, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 101, 138, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 171, 217, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 256, 220, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 445, 221, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 51, 195, 0, 1272));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 70, 193, 0, 1272));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
