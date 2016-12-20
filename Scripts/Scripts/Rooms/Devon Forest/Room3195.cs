using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3195 : Room
{
public Room3195()
: base(3195, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 422, 104, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 133, 307, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 322, 385, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 536, 295, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 297, 322, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 366, 184, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 206, 103, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 555, 287, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 65515, 183, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 62, 114, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 627, 118, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 178, 119, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 65525, 214, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 577, 292, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 133, 313, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 330, 237, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 247, 233, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 242, 232, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 113, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 113, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 120, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 119, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 608, 119, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 631, 119, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 562, 105, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 560, 118, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 499, 134, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 468, 172, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 495, 167, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 459, 165, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 339, 180, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 224, 180, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 100, 183, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 50, 214, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 170, 211, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 291, 211, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 404, 213, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 539, 154, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 567, 128, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 558, 111, 0, 3195));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 6, 214, 0, 3195));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3189;
                case RoomExit.South: return 3251;
                case RoomExit.East:  return 3196;
                case RoomExit.West:  return 3194;
                default: return 0;
            }
        }
}
}
