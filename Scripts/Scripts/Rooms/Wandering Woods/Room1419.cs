using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1419 : Room
{
public Room1419()
: base(1419, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 520, 113, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 73, 111, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 113, 244, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 165, 201, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 213, 197, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 202, 8, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 114, 245, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 192, 201, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 527, 122, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 432, 137, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 606, 133, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65479, 102, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 259, 103, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 460, 103, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 431, 102, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(32923, 618, 134, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 136, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 136, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 135, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 121, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 122, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 134, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 134, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 121, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 314, 105, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 308, 132, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 307, 112, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 308, 151, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 244, 182, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 237, 174, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 144, 202, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 40, 203, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 297, 146, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 617, 283, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 630, 230, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 572, 291, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 560, 239, 0, 1419));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 582, 195, 0, 1419));



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
