using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1201 : Room
{
public Room1201()
: base(1201, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 105, 109, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 609, 122, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 339, 120, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 56, 325, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 250, 239, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 338, 122, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 221, 59, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 151, 295, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 287, 62, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 335, 118, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 38, 287, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65533, 307, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 50, 246, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 62, 242, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 2, 264, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 202, 255, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 121, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 124, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 123, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 123, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 595, 204, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 60, 195, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 325, 203, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 202, 201, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 452, 202, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 66, 99, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 146, 230, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 269, 235, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 410, 237, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 527, 247, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 537, 239, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 526, 200, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 33, 172, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 285, 277, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 65532, 156, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 27, 223, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 624, 235, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 722, 195, 0, 1201));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 637, 190, 0, 1201));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4046;
                case RoomExit.South: return 1207;
                case RoomExit.East:  return 1202;
                case RoomExit.West:  return 1201;
                default: return 0;
            }
        }
}
}
