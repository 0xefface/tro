using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1252 : Room
{
public Room1252()
: base(1252, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 453, 139, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 145, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 302, 246, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 265, 253, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 485, 320, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 525, 297, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 247, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 222, 237, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 180, 263, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 426, 221, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 564, 304, 20, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 35, 210, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 594, 308, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(33003, 267, 164, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 110, 193, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 317, 268, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 309, 256, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 213, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 27, 164, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 91, 163, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 113, 139, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 139, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 130, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 131, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 139, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 145, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 145, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 138, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 146, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 145, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 143, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 149, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 149, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 143, 0, 1252));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 143, 0, 1252));



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
