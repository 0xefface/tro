using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1261 : Room
{
public Room1261()
: base(1261, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 127, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 290, 131, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 155, 141, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 248, 138, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 324, 137, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 85, 136, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 44, 243, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 447, 235, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 633, 261, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 421, 260, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 212, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(32870, 65519, 316, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 314, 239, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 617, 259, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 198, 139, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 140, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 141, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 53, 281, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 147, 228, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 591, 226, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 378, 229, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 113, 227, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 332, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 6, 317, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 94, 211, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 59, 224, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 213, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 393, 265, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 389, 255, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 467, 247, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 598, 261, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 580, 246, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 550, 257, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 514, 261, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 207, 336, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 141, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 137, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 144, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 139, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 140, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 140, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 137, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 137, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 136, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 135, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 135, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 287, 122, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 282, 145, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 280, 124, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 290, 237, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 286, 202, 0, 1261));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 277, 172, 0, 1261));



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
