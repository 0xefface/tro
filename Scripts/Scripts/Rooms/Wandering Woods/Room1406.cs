using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1406 : Room
{
public Room1406()
: base(1406, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(49, 602, 331, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 250, 103, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 46, 104, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 513, 106, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 89, 114, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 192, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 120, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 299, 117, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 26, 134, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 441, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 513, 129, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 597, 127, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 455, 307, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 345, 318, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 28, 136, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 134, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 134, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 127, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 127, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 118, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 118, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 118, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 120, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 119, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 119, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 124, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 124, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 129, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 129, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 129, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 126, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 127, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 305, 191, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(205, 243, 97, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 223, 114, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 254, 131, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 540, 196, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 408, 195, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 626, 198, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 246, 196, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 534, 231, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 524, 267, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 608, 230, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 260, 139, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 280, 200, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 346, 224, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 561, 227, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 484, 184, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 484, 227, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 477, 288, 0, 1406));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 226, 120, 0, 1406));



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
