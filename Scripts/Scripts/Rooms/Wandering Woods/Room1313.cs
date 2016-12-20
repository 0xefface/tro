using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1313 : Room
{
public Room1313()
: base(1313, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 327, 137, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 473, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 32, 204, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 333, 249, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 572, 267, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 114, 241, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 77, 203, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 150, 241, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 240, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 342, 310, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 583, 265, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 46, 203, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 90, 192, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 132, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 136, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 138, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 147, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 145, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 139, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 137, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 144, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 143, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 83, 203, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 257, 244, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 243, 206, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 213, 201, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 163, 200, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 173, 205, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 146, 193, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 281, 243, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 273, 221, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 226, 246, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 242, 225, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 317, 244, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 329, 253, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 293, 230, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 274, 228, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 216, 316, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 302, 263, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 315, 284, 0, 1313));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 328, 297, 0, 1313));


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
