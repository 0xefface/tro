using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1137 : Room
{
public Room1137()
: base(1137, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 419, 104, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 105, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 586, 113, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 94, 273, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 113, 274, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65512, 7, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 224, 104, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 267, 105, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 443, 111, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 612, 287, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 643, 304, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 452, 316, 0, 1137));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 585, 290, 0, 1137));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1129;
                case RoomExit.South: return 1146;
                case RoomExit.East:  return 1138;
                case RoomExit.West:  return 1136;
                default: return 0;
            }
        }
}
}
