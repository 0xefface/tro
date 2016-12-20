using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1435 : Room
{
public Room1435()
: base(1435, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 534, 292, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 112, 184, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 204, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 208, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 596, 317, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 112, 188, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 104, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 287, 264, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 218, 120, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 526, 118, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 198, 112, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 115, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 464, 119, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 286, 275, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 24, 116, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 48, 116, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 115, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 120, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 212, 120, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 235, 120, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 120, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 119, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 464, 118, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 119, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 117, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 119, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 119, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 555, 99, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 495, 224, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 608, 282, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 596, 292, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 624, 306, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 651, 220, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 631, 228, 0, 1435));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 604, 230, 0, 1435));



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
