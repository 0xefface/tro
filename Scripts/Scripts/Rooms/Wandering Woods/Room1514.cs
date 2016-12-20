using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1514 : Room
{
public Room1514()
: base(1514, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 16, 118, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 532, 121, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 293, 121, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 385, 132, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 638, 142, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 116, 124, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 400, 128, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 303, 133, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 210, 137, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 22, 125, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 566, 131, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 39, 211, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 249, 246, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 213, 248, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 592, 247, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 43, 291, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 74, 207, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 335, 322, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 437, 321, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 30, 205, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 402, 347, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 125, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 631, 143, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 124, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 119, 124, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 137, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 131, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 133, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 105, 124, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 602, 142, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 284, 131, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 49, 216, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(33003, 139, 102, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 157, 122, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 161, 118, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 159, 129, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 167, 124, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 145, 140, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 130, 176, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 137, 140, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 133, 146, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 130, 158, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 113, 201, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 119, 189, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 124, 175, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 124, 167, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 144, 140, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 175, 241, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 189, 233, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 101, 226, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 219, 298, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 251, 294, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 259, 277, 0, 1514));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 271, 290, 0, 1514));



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
