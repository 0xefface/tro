using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1378 : Room
{
public Room1378()
: base(1378, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 339, 125, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 441, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 142, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 541, 142, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 307, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 380, 142, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 506, 139, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 101, 214, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 516, 306, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 575, 191, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 542, 299, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 330, 248, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 484, 237, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 31, 244, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 99, 225, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 123, 224, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 551, 231, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 498, 278, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 538, 252, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 611, 239, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 555, 216, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 410, 281, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 333, 276, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 578, 252, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 481, 236, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 394, 255, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 320, 247, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 518, 236, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 358, 242, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 614, 284, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 506, 288, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 106, 223, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 574, 305, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 114, 236, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 52, 268, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 102, 225, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 253, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 55, 250, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 206, 138, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 50, 144, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 99, 139, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 139, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 139, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 138, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 222, 138, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 242, 138, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 145, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 142, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 141, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 141, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 140, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 143, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 143, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 143, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 142, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 593, 306, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 551, 249, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(34073, 522, 103, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(34073, 534, 80, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 209, 251, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 432, 251, 0, 1378));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 66, 251, 0, 1378));



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
