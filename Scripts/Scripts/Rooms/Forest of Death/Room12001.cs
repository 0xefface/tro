using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12001 : Room
{
public Room12001()
: base(12001, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 114, 127, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 517, 138, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 355, 134, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 295, 146, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 251, 138, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 172, 131, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 218, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 248, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 623, 167, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 516, 279, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 177, 264, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 93, 202, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 183, 262, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 599, 171, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 122, 172, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 517, 278, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 193, 246, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 177, 233, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 266, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 422, 296, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 481, 282, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 31, 218, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 76, 193, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 40, 203, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 19, 219, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 620, 168, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 602, 172, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 204, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 96, 181, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 144, 205, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 353, 262, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 128, 142, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 211, 144, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 406, 132, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 140, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 140, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 210, 143, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 143, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 312, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 145, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 137, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 138, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 137, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 137, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 12001));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 137, 0, 12001));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10047;
                case RoomExit.South: return 12006;
                case RoomExit.East:  return 12002;
                case RoomExit.West:  return 12000;
                default: return 0;
            }
        }
}
}
