using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1398 : Room
{
public Room1398()
: base(1398, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(185, 43, 170, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 500, 110, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 5, 174, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 215, 322, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 24, 164, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 58, 166, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 2, 146, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32941, 130, 103, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 48, 154, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 25, 139, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 262, 28, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 531, 110, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 0, 187, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 29, 255, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 15, 170, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 86, 252, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 49, 272, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 12, 103, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 65535, 194, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 60, 236, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 41, 176, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 283, 199, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 1, 215, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 347, 286, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 312, 204, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 62, 172, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 46, 217, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 31, 108, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 15, 332, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 21, 113, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 739, 93, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 63, 102, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 618, 238, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 480, 125, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 622, 242, 0, 1398));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 375, 108, 0, 1398));



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
