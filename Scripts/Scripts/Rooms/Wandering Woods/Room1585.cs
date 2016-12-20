using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1585 : Room
{
public Room1585()
: base(1585, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 114, 127, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 517, 138, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 355, 134, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 295, 146, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 251, 138, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 172, 131, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 218, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 248, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 623, 167, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 516, 279, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 177, 264, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 40, 257, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 183, 262, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 599, 171, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 544, 279, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 517, 278, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 193, 246, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 59, 261, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 620, 168, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 602, 172, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 204, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 144, 205, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 353, 262, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 128, 142, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 211, 144, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 406, 132, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 140, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 140, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 210, 143, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 143, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 312, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 145, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 137, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 138, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 137, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 137, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 1585));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 137, 0, 1585));



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
