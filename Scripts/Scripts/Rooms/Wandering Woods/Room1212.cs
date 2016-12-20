using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1212 : Room
{
public Room1212()
: base(1212, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 372, 103, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 184, 103, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 498, 115, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 431, 318, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 452, 315, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 299, 307, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 415, 322, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 156, 132, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 457, 106, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 19, 121, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 130, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 130, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 131, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 225, 118, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 122, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 121, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 116, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 116, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 20, 122, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 61, 116, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 111, 237, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 403, 297, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 168, 283, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 27, 215, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 34, 218, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 22, 321, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 60, 219, 0, 1212));
this.AddRoomDecoration(RoomDecoration.FromCode(32951, 39, 211, 0, 1212));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1206;
                case RoomExit.South: return 1218;
                case RoomExit.East:  return 1213;
                case RoomExit.West:  return 1185;
                default: return 0;
            }
        }
}
}
