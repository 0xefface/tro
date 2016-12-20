using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1449 : Room
{
public Room1449()
: base(1449, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 644, 103, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 374, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 318, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 508, 321, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 422, 227, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 105, 47, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 37, 319, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 614, 202, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 614, 327, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 599, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 135, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 138, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 137, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 139, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 138, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 139, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 124, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 146, 124, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 124, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 99, 122, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 122, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 121, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 205, 203, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 183, 197, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 64, 197, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 195, 213, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 249, 220, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 265, 247, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 291, 252, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 265, 208, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 502, 102, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 533, 185, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 580, 156, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 536, 251, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 564, 276, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 566, 276, 0, 1449));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 588, 277, 0, 1449));


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
