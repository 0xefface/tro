using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1209 : Room
{
public Room1209()
: base(1209, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65476, 103, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 490, 112, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 185, 112, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 462, 193, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 403, 214, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 342, 201, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 348, 208, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 371, 224, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 462, 201, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 461, 219, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 462, 191, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 359, 199, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 419, 228, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 406, 210, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 33, 260, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 91, 266, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 77, 258, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 45, 264, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 22, 254, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 469, 192, 0, 1209));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 478, 105, 0, 1209));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1203;
                case RoomExit.South: return 1215;
                case RoomExit.East:  return 1210;
                case RoomExit.West:  return 1208;
                default: return 0;
            }
        }
}
}
