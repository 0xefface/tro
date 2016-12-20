using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1107 : Room
{
public Room1107()
: base(1107, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 319, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 155, 208, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 120, 185, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 150, 213, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 127, 176, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 113, 186, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(33010, 601, 87, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 179, 216, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 104, 192, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 174, 200, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 116, 205, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 188, 185, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 223, 203, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 145, 188, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 137, 223, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 256, 204, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 231, 207, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 203, 218, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 98, 225, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 177, 225, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 226, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 92, 206, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 110, 209, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 60, 194, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 93, 193, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 223, 187, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 203, 187, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 602, 304, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 638, 294, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 557, 320, 0, 1107));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 631, 318, 0, 1107));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22040;
                case RoomExit.South: return 1113;
                case RoomExit.East:  return 1108;
                case RoomExit.West:  return 22046;
                default: return 0;
            }
        }
}
}
