using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1151 : Room
{
public Room1151()
: base(1151, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 110, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 197, 187, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 74, 135, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 33, 128, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 461, 274, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 477, 281, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 190, 190, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 312, 104, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 135, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 135, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 127, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 127, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 127, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 318, 104, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 294, 240, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 324, 232, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 316, 187, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 312, 133, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 314, 111, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 322, 159, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 310, 158, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 330, 191, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 432, 235, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 578, 286, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 581, 126, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 199, 305, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 165, 274, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 558, 318, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 518, 217, 0, 1151));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 570, 109, 0, 1151));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1043;
                case RoomExit.South: return 1157;
                case RoomExit.East:  return 1152;
                case RoomExit.West:  return 1150;
                default: return 0;
            }
        }
}
}
