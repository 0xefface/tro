using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1553 : Room
{
public Room1553()
: base(1553, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 22, 137, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 176, 132, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 552, 127, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 569, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 212, 140, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 629, 143, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 479, 144, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 75, 138, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 303, 142, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 520, 140, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 437, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 11, 139, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 353, 138, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 308, 243, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 426, 276, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 99, 221, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 508, 264, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 593, 223, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 469, 273, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 333, 247, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 324, 127, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 87, 217, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 230, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 545, 280, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 117, 221, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 367, 243, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 615, 225, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 60, 211, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 137, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 142, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 193, 139, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 139, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 142, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 138, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 143, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 440, 141, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 144, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 504, 290, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 265, 123, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 304, 175, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 312, 171, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 419, 195, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 592, 206, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 594, 198, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 259, 146, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 260, 126, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(136, 224, 217, 0, 1553));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 65531, 255, 0, 1553));



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
