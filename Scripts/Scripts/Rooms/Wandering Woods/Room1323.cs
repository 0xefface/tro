using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1323 : Room
{
public Room1323()
: base(1323, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 143, 114, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 553, 126, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 383, 121, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 453, 139, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 605, 158, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 197, 138, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 245, 123, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 332, 140, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 53, 129, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 153, 128, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 39, 210, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 247, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 94, 185, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 629, 267, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 394, 230, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 6, 321, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 157, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 157, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 144, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 144, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 364, 257, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 430, 223, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 60, 214, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 137, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 196, 137, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 137, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 126, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 126, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 301, 139, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 121, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 145, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 145, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 138, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 284, 103, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 277, 132, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 278, 111, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 277, 160, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 259, 210, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 243, 239, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 277, 231, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 286, 187, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 284, 158, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 335, 261, 0, 1323));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 192, 245, 0, 1323));



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
