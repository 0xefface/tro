using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1219 : Room
{
public Room1219()
: base(1219, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 451, 104, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 242, 103, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 112, 112, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 271, 200, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 78, 276, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 277, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 263, 201, 8, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 277, 196, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 263, 210, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 58, 274, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 92, 293, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 279, 196, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 74, 270, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(246, 494, 31, 0, 1219));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 541, 114, 0, 1219));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1213;
                case RoomExit.South: return 1225;
                case RoomExit.East:  return 1220;
                case RoomExit.West:  return 1218;
                default: return 0;
            }
        }
}
}
