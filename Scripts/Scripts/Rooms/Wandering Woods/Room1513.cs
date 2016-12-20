using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1513 : Room
{
public Room1513()
: base(1513, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 327, 137, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 473, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 32, 204, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 334, 246, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 572, 267, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 239, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 102, 188, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 143, 238, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 240, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 109, 212, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 583, 265, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 32, 216, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 90, 192, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 132, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 136, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 138, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 147, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 145, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 139, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 137, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 144, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 143, 0, 1513));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 230, 318, 0, 1513));



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
