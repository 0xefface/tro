using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1190 : Room
{
public Room1190()
: base(1190, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 348, 139, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 133, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 131, 137, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 145, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 331, 149, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 140, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 507, 156, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 422, 143, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 203, 142, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 170, 140, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 460, 147, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 127, 142, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 77, 145, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 431, 326, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 339, 298, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 26, 256, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 124, 215, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 605, 207, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 475, 255, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 324, 246, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 110, 111, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 477, 138, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 121, 220, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 259, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 145, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 164, 144, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 310, 310, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 540, 146, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 287, 268, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 454, 324, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 247, 318, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 286, 312, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 360, 315, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 144, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 143, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 144, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 146, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 144, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 142, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 148, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 149, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 142, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 141, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 156, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 156, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 146, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 146, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 60, 223, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 57, 233, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 209, 196, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 224, 200, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 279, 124, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 275, 167, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 274, 144, 0, 1190));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 273, 126, 0, 1190));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1184;
                case RoomExit.South: return 1196;
                case RoomExit.East:  return 1191;
                case RoomExit.West:  return 1189;
                default: return 0;
            }
        }
}
}
