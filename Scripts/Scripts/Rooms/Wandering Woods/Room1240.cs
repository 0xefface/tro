using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1240 : Room
{
public Room1240()
: base(1240, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 319, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 112, 184, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 206, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 129, 205, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 108, 185, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 639, 56, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 164, 211, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 436, 323, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 134, 180, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 115, 322, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 578, 311, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 475, 110, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 280, 106, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 276, 134, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 275, 110, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 193, 196, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 281, 157, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 270, 156, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 208, 201, 0, 1240));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 93, 224, 0, 1240));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1234;
                case RoomExit.South: return 1246;
                case RoomExit.East:  return 1241;
                case RoomExit.West:  return 1240;
                default: return 0;
            }
        }
}
}
