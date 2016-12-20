using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1698 : Room
{
public Room1698()
: base(1698, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.DownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(100, 135, 320, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 337, 327, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 619, 183, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 637, 168, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 166, 119, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 225, 103, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 119, 135, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 516, 138, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 585, 341, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 101, 208, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 208, 280, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(122, 10, 398, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 448, 141, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 386, 131, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 501, 130, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 478, 130, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 246, 113, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 218, 119, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 193, 125, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 47, 138, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 589, 130, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 587, 201, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 600, 304, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 519, 335, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 623, 267, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 636, 156, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 482, 336, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 565, 251, 0, 1698));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 547, 334, 0, 1698));



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
