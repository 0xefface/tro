using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1472 : Room
{
public Room1472()
: base(1472, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 22, 137, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 176, 132, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 552, 127, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 569, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 212, 140, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 629, 143, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 479, 144, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 75, 138, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 303, 142, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 520, 140, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 437, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 11, 139, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 353, 138, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 342, 251, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 426, 276, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 99, 221, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 508, 264, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 593, 223, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 469, 273, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 632, 207, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 324, 127, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 87, 217, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 230, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 403, 236, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 117, 221, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 367, 243, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 615, 225, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 60, 211, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 137, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 142, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 139, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 142, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 138, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 143, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 440, 141, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 144, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 504, 290, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 264, 120, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 256, 144, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 258, 124, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 253, 172, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 230, 225, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 255, 226, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 267, 176, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 265, 150, 0, 1472));
this.AddRoomDecoration(RoomDecoration.FromCode(32907, 698, 316, 0, 1472));



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
