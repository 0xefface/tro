using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1140 : Room
{
public Room1140()
: base(1140, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 89, 112, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 531, 112, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 126, 115, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 172, 182, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 188, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 464, 317, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 169, 185, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 257, 38, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 248, 356, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 182, 189, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 489, 172, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 613, 317, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 484, 171, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 528, 300, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 477, 171, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 512, 163, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 484, 307, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 426, 317, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 17, 122, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(32877, 571, 316, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 676, 295, 0, 1140));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 632, 303, 0, 1140));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22099;
                case RoomExit.South: return 1250;
                case RoomExit.East:  return 1141;
                case RoomExit.West:  return 5904;
                default: return 0;
            }
        }
}
}
