using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2909 : Room
{
public Room2909()
: base(2909, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32889, 646, 289, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 202, 268, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 199, 166, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 82, 293, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 49, 274, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1590, 277, 162, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1591, 317, 165, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 160, 158, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 38, 129, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 79, 112, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 53, 96, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 53, 144, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 35, 192, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 151, 199, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 190, 226, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 248, 201, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 322, 226, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 37, 216, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 70, 218, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 638, 146, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 129, 270, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 185, 290, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 307, 259, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 327, 285, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 276, 245, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 50, 287, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 257, 265, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 26, 178, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 652, 253, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 627, 294, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 175, 164, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 541, 244, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(58067, 244, 0, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 117, 290, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 9, 240, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 315, 219, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 37, 241, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 624, 233, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 630, 99, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 589, 162, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 631, 183, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 697, 190, 0, 2909));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 659, 118, 0, 2909));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2904;
                case RoomExit.South: return 2914;
                case RoomExit.East:  return 2908;
                case RoomExit.West:  return 10000;
                default: return 0;
            }
        }
}
}
