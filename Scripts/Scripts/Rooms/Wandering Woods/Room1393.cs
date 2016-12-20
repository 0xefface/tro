using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1393 : Room
{
public Room1393()
: base(1393, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 142, 130, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 380, 139, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 517, 144, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 620, 143, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 74, 135, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 396, 140, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 251, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 343, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 462, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 310, 249, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 530, 274, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 342, 267, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 435, 220, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 143, 240, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 519, 114, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 488, 370, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 202, 239, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 254, 230, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 163, 241, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 315, 262, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 19, 217, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 444, 231, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 526, 275, 12, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 170, 240, 12, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 238, 240, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 136, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 134, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 139, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 127, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 140, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 139, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 139, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 141, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 139, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 412, 137, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 143, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 142, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(34072, 630, 96, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(34074, 349, 101, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65525, 317, 0, 1393));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 65517, 251, 0, 1393));



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
