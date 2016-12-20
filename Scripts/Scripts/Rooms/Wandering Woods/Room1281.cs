using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1281 : Room
{
public Room1281()
: base(1281, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65504, 124, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 566, 135, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 531, 137, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 586, 145, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 242, 142, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 390, 136, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 51, 142, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 283, 133, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 102, 137, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 137, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 616, 319, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 264, 297, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 314, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 395, 228, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 325, 272, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 111, 247, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 60, 261, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 133, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 362, 326, 65516, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 267, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 408, 241, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 403, 233, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 139, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 115, 323, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 583, 306, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 524, 319, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 228, 344, 20, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 248, 323, 20, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 427, 327, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 364, 240, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 134, 320, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 216, 302, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 408, 317, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 306, 312, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 106, 265, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 144, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 328, 364, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 139, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 392, 166, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 141, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 141, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 138, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 136, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 142, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 278, 132, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 132, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 141, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 140, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(197, 277, 105, 0, 1281));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65510, 257, 0, 1281));



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
