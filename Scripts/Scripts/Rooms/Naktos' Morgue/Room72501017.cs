using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room72501017 : Room
{
public Room72501017()
: base(72501017, "Naktos' Morgue")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DarkCave;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(1752, 89, 222, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1830, 196, 232, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1831, 348, 231, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1751, 446, 224, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1750, 542, 235, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(34518, 584, 260, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1751, 665, 293, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(34540, 617, 310, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1772, 558, 296, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1780, 613, 330, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 13, 327, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 486, 244, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 106, 231, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 426, 279, 47, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 592, 319, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(40672, 556, 308, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 198, 239, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 348, 240, 0, 72501017));
this.AddRoomDecoration(RoomDecoration.FromCode(1850, 65523, 324, 0, 72501017));



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
