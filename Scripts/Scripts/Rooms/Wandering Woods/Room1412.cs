using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1412 : Room
{
public Room1412()
: base(1412, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 506, 121, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 41, 119, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 121, 251, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 155, 254, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 109, 255, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 84, 144, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 138, 253, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 553, 240, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 585, 238, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 69, 143, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 93, 147, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 563, 241, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 121, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 122, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 122, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 55, 119, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 120, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 119, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 329, 105, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 323, 131, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 322, 109, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 320, 153, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 304, 193, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 285, 241, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 318, 234, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 326, 184, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 328, 158, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 590, 237, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 568, 113, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 600, 106, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 607, 130, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 527, 254, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 529, 200, 0, 1412));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 576, 198, 0, 1412));



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
