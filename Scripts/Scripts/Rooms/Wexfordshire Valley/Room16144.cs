using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room16144 : Room
{
public Room16144()
: base(16144, "Wexfordshire Valley")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(114, 119, 292, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 352, 284, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 186, 301, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 61, 316, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 102, 105, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(33008, 76, 55, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 114, 83, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 298, 103, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 223, 292, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 281, 283, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 308, 295, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32931, 65453, 122, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65517, 98, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 165, 241, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 109, 201, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 54, 167, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 212, 279, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 63, 236, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 581, 104, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 606, 104, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 628, 102, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 631, 105, 0, 16144));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 604, 321, 0, 16144));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1597;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 16145;
                case RoomExit.West:  return 1674;
                default: return 0;
            }
        }
}
}
