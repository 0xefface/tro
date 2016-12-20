using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1129 : Room
{
public Room1129()
: base(1129, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 68, 117, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 429, 111, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 289, 103, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 319, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 55, 280, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 30, 278, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(246, 207, 43, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 209, 94, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 28, 292, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 467, 326, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 829, 104, 0, 1129));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 685, 196, 0, 1129));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1122;
                case RoomExit.South: return 1137;
                case RoomExit.East:  return 1130;
                case RoomExit.West:  return 1128;
                default: return 0;
            }
        }
}
}
