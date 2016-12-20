using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1428 : Room
{
public Room1428()
: base(1428, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 125, 111, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 398, 274, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 144, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 119, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 482, 247, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 9, 178, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 345, 110, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 466, 250, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 196, 178, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 137, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 74, 120, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 338, 154, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 219, 122, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 551, 145, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 576, 145, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 590, 144, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 555, 140, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 582, 139, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 65535, 124, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 136, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 136, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 123, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 23, 119, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 47, 121, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 120, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 119, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 121, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 48, 349, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 612, 372, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 213, 318, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 152, 303, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 603, 315, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 274, 327, 0, 1428));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 639, 302, 0, 1428));



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
