using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1493 : Room
{
public Room1493()
: base(1493, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 348, 139, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 133, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 131, 137, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 145, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 331, 149, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 140, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 507, 156, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 422, 143, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 203, 142, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 140, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 460, 147, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 127, 142, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 77, 145, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 432, 309, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 493, 317, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 26, 256, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 119, 227, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 605, 207, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 475, 255, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 324, 246, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 110, 111, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 477, 138, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 128, 228, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 259, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 145, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 164, 144, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 352, 313, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 190, 220, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 430, 315, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 372, 305, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 82, 314, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 70, 263, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 144, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 143, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 144, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 146, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 144, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 142, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 148, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 149, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 142, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 141, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 156, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 156, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 146, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 146, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 263, 121, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 257, 144, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 256, 125, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 260, 170, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 244, 208, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 223, 228, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 263, 230, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 267, 183, 0, 1493));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 268, 171, 0, 1493));



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
