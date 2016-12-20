using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1143 : Room
{
public Room1143()
: base(1143, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 403, 104, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 466, 304, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 50, 241, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 234, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 355, 310, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 33, 243, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 27, 248, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 401, 314, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 428, 318, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 237, 0, 1143));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 14, 239, 0, 1143));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1134;
                case RoomExit.South: return 1253;
                case RoomExit.East:  return 1144;
                case RoomExit.West:  return 1142;
                default: return 0;
            }
        }
}
}
