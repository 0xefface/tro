using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1591 : Room
{
public Room1591()
: base(1591, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65504, 124, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 566, 135, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 531, 137, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 586, 145, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 242, 142, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 390, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 51, 142, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 323, 143, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 102, 137, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 137, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 636, 318, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 264, 297, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 419, 251, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 352, 247, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 478, 238, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 31, 257, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 345, 113, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 138, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 362, 326, 65516, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 267, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 120, 219, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 127, 251, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 490, 240, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 416, 241, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 139, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 115, 323, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 619, 308, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 632, 309, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 228, 344, 20, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 248, 323, 20, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 427, 327, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 364, 240, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 134, 320, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 216, 302, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 383, 316, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 314, 304, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 127, 219, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 144, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 383, 385, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 392, 166, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 141, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 141, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 138, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 136, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 142, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 336, 143, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 141, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 141, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 140, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 431, 263, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 350, 219, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 465, 263, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 273, 181, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 282, 111, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 270, 156, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 279, 132, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 203, 211, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 39, 215, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 224, 214, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 479, 265, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 495, 279, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 521, 294, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 323, 240, 0, 1591));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 644, 200, 0, 1591));



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
