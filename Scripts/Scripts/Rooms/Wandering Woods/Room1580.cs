using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1580 : Room
{
public Room1580()
: base(1580, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65503, 129, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 422, 131, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 359, 132, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 622, 143, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 134, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 137, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 147, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 175, 130, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 529, 137, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 409, 270, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 489, 260, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 491, 239, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 262, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 219, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 597, 209, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 26, 255, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 102, 239, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 111, 230, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 141, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 134, 239, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 216, 219, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 129, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 262, 225, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 500, 233, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 145, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 137, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 129, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 136, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 136, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 136, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 137, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 145, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 132, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 133, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 135, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 135, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(133, 15, 328, 0, 1580));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 23, 311, 0, 1580));



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
