using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1697 : Room
{
public Room1697()
: base(1697, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(100, 135, 320, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 337, 327, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 445, 323, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 549, 326, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(106, 632, 315, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 225, 103, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 119, 135, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 516, 138, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 107, 201, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 101, 208, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 390, 285, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(122, 409, 274, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 448, 141, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 386, 131, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 501, 130, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 478, 130, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 246, 113, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 218, 119, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 193, 125, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 47, 138, 0, 1697));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 166, 119, 0, 1697));


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
