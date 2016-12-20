using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1144 : Room
{
public Room1144()
: base(1144, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65464, 104, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 304, 106, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 295, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 71, 276, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 48, 276, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 81, 296, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 92, 295, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 669, 312, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 115, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 121, 0, 1144));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 423, 112, 0, 1144));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1135;
                case RoomExit.South: return 1254;
                case RoomExit.East:  return 1145;
                case RoomExit.West:  return 1143;
                default: return 0;
            }
        }
}
}
