using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1480 : Room
{
public Room1480()
: base(1480, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 551, 135, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 303, 134, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 125, 140, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 383, 144, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 584, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 318, 329, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 323, 265, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 234, 254, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 320, 252, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 176, 245, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 431, 221, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 134, 119, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 29, 209, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 84, 208, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 48, 207, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 60, 204, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 371, 231, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 207, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 24, 217, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 160, 230, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 176, 242, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 250, 254, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 225, 235, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 266, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 312, 246, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 282, 265, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 450, 229, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 428, 216, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 282, 233, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 591, 331, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 165, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 138, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 140, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 144, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 145, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 194, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 69, 194, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 135, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 134, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 133, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 140, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 139, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 277, 109, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 269, 138, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 271, 113, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 226, 166, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 220, 162, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 161, 189, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 127, 189, 0, 1480));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 32, 211, 0, 1480));



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
