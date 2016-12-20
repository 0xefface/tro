using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1241 : Room
{
public Room1241()
: base(1241, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(45, 486, 248, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 492, 249, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 198, 118, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 127, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 115, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 335, 103, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 26, 126, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 117, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 117, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 117, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 37, 309, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(32951, 57, 318, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 606, 314, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 610, 209, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 615, 206, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 668, 311, 0, 1241));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 583, 205, 0, 1241));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1235;
                case RoomExit.South: return 1247;
                case RoomExit.East:  return 4142;
                case RoomExit.West:  return 1240;
                default: return 0;
            }
        }
}
}
