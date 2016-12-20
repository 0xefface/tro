using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1488 : Room
{
public Room1488()
: base(1488, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 554, 128, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 366, 128, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 127, 127, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 114, 132, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 497, 135, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 176, 133, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 51, 149, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 615, 144, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 433, 133, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 133, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 556, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 323, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 373, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 434, 240, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 251, 296, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 606, 210, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 337, 332, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 581, 247, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 180, 240, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 568, 204, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 20, 253, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 267, 189, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 171, 241, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 245, 297, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 498, 289, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 622, 211, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 352, 194, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 81, 266, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 56, 173, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 56, 197, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 175, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 66, 148, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 148, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 105, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 132, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 130, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 130, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 130, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 130, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 131, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 134, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 134, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 521, 134, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 133, 0, 1488));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 372, 239, 0, 1488));



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
