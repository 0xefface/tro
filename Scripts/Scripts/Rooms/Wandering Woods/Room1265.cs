using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1265 : Room
{
public Room1265()
: base(1265, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 90, 124, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 555, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 329, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 504, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 618, 144, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 98, 138, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 179, 138, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 311, 141, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 385, 143, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 446, 145, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 225, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 369, 267, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 411, 258, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 263, 319, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 510, 261, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 48, 261, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 215, 212, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 461, 239, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32968, 431, 271, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 57, 258, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 211, 215, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 433, 272, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 376, 278, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 262, 325, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 421, 256, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 460, 256, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 54, 258, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 137, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 137, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 137, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 227, 140, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 140, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 141, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 144, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 432, 145, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 145, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 139, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 150, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 150, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 143, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 143, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 153, 116, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 148, 144, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 146, 118, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 145, 167, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 148, 199, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 153, 231, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 122, 266, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 159, 201, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 489, 271, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 549, 256, 0, 1265));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 615, 151, 0, 1265));



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
