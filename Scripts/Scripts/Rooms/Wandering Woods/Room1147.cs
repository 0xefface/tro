using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1147 : Room
{
public Room1147()
: base(1147, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 418, 103, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 213, 102, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 334, 103, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 555, 107, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 19, 119, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 29, 324, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 500, 228, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 291, 156, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 292, 159, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 486, 255, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 526, 246, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 89, 317, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 186, 103, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 246, 118, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 404, 313, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 433, 239, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 492, 246, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 577, 89, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 38, 305, 0, 1147));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65511, 227, 0, 1147));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1138;
                case RoomExit.South: return 1257;
                case RoomExit.East:  return 1148;
                case RoomExit.West:  return 1146;
                default: return 0;
            }
        }
}
}
