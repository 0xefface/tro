using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1342 : Room
{
public Room1342()
: base(1342, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 556, 162, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 173, 139, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 243, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 292, 142, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 502, 150, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 103, 132, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 621, 258, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 464, 205, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 606, 262, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 326, 256, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 84, 203, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 266, 175, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 130, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 53, 209, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 581, 338, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 194, 268, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 159, 270, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 335, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 222, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 350, 262, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 312, 245, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 230, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 617, 252, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 621, 263, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 542, 160, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 576, 318, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 512, 161, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 271, 176, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 45, 329, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 468, 228, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 234, 134, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 503, 222, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 429, 251, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 514, 222, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 86, 217, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 138, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 167, 138, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 191, 139, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 255, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 130, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 141, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 140, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 138, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 149, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 162, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 162, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 51, 209, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 262, 172, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 99, 245, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 191, 206, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 359, 170, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 169, 174, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(32982, 146, 209, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 317, 201, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 359, 219, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(930, 361, 254, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 361, 253, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 333, 230, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 384, 232, 0, 1342));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 20, 242, 0, 1342));


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
