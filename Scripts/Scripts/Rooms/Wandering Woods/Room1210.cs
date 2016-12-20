using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1210 : Room
{
public Room1210()
: base(1210, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 107, 111, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 568, 124, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 217, 302, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 320, 321, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 280, 314, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 151, 330, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 191, 309, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 263, 305, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 245, 104, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 160, 299, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 208, 287, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 112, 317, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 1210));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 1210));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1204;
                case RoomExit.South: return 1216;
                case RoomExit.East:  return 1211;
                case RoomExit.West:  return 1209;
                default: return 0;
            }
        }
}
}
