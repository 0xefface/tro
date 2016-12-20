using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1291 : Room
{
public Room1291()
: base(1291, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 142, 133, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 186, 139, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 111, 217, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 221, 221, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 105, 227, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 43, 253, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 258, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 317, 205, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 141, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 398, 254, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 628, 307, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 345, 262, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 349, 240, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 267, 231, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 270, 138, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 138, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 139, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 145, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 136, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 135, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 131, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 131, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 131, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 29, 124, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 459, 137, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 148, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 142, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 619, 142, 0, 1291));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 634, 210, 0, 1291));



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
