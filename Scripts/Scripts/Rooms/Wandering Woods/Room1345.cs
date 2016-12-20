using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1345 : Room
{
public Room1345()
: base(1345, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65506, 122, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 438, 134, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 238, 127, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 617, 127, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 140, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 320, 138, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 196, 219, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 401, 243, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 210, 223, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 68, 247, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 233, 216, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 36, 256, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 444, 260, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 416, 262, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 586, 210, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 598, 208, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 32924, 524, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 154, 205, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 131, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 142, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 141, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 170, 142, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 127, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 136, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 136, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 135, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 140, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 140, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 138, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 144, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 144, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 131, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 145, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 606, 198, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 621, 198, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 306, 163, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 273, 110, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 267, 135, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 268, 114, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 318, 163, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 400, 181, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 530, 199, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 552, 197, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 675, 221, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 640, 213, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 477, 192, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 453, 200, 0, 1345));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 44, 260, 0, 1345));



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
