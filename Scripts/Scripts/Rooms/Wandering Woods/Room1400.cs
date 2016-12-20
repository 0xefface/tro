using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1400 : Room
{
public Room1400()
: base(1400, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 170, 108, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 523, 119, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 183, 120, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 365, 236, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 593, 125, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 109, 131, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 213, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 465, 107, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 370, 239, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 428, 119, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 181, 134, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 123, 130, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 502, 124, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 46, 269, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 80, 268, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 257, 222, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 246, 221, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 302, 227, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 359, 235, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 261, 225, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 131, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 132, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 133, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 133, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 134, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 132, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 119, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 121, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 121, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 124, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 125, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 125, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 125, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 126, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 126, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 125, 0, 1400));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 67, 273, 0, 1400));



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
