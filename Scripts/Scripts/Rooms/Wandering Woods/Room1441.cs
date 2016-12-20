using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1441 : Room
{
public Room1441()
: base(1441, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 47, 105, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 502, 309, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 135, 211, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 145, 217, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 143, 211, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 177, 209, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 378, 118, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 430, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 107, 108, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 200, 117, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 332, 108, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 14, 110, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 484, 314, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 550, 305, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 211, 117, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 118, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 119, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 279, 104, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 304, 146, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 331, 175, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 347, 227, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 373, 235, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 343, 178, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 338, 167, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 272, 126, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 274, 107, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 287, 157, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 321, 174, 0, 1441));
this.AddRoomDecoration(RoomDecoration.FromCode(32906, 135, 209, 0, 1441));



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
