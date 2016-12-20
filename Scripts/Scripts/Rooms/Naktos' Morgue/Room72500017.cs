using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room72500017 : Room
{
public Room72500017()
: base(72500017, "Naktos' Morgue")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DarkCave;
this.BlockedRoomExits = BlockedExits.UpDown;
this.AddRoomDecoration(RoomDecoration.FromCode(1750, 324, 236, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(34640, 131, 278, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(1873, 505, 282, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(34642, 320, 277, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(1752, 560, 222, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(1752, 183, 229, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(34519, 426, 248, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(34518, 45, 233, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(1850, 33, 323, 6, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 499, 319, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 219, 322, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 42, 317, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 130, 333, 91, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 553, 227, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 456, 252, 0, 72500017));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 313, 253, 0, 72500017));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 72501017;
                case RoomExit.West:  return 72508017;
                default: return 0;
            }
        }
}
}
