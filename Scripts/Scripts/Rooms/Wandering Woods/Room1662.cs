using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1662 : Room
{
public Room1662()
: base(1662, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 556, 162, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 127, 139, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 243, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 292, 142, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 502, 150, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 111, 132, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 621, 258, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 422, 222, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 606, 262, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 287, 262, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 205, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 309, 249, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 184, 129, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 48, 204, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 581, 338, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 194, 268, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 159, 270, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 335, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 222, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 284, 258, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 312, 245, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 230, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 617, 252, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 621, 263, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 542, 160, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 582, 256, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 512, 161, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 260, 193, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 198, 266, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 460, 205, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 234, 134, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 513, 224, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 537, 233, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 514, 222, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 86, 217, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 255, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 130, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 141, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 140, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 149, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 162, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 162, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 130, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 189, 109, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 104, 231, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 76, 233, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 185, 154, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 127, 188, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 109, 208, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 131, 201, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 149, 195, 0, 1662));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 157, 187, 0, 1662));



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
