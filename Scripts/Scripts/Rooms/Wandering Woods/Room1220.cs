using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1220 : Room
{
public Room1220()
: base(1220, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 459, 102, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 658, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 50, 121, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 284, 283, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 401, 144, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 291, 285, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 297, 274, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 422, 146, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 412, 146, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 477, 115, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 133, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 631, 310, 0, 1220));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 621, 300, 0, 1220));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1214;
                case RoomExit.South: return 1226;
                case RoomExit.East:  return 1221;
                case RoomExit.West:  return 1219;
                default: return 0;
            }
        }
}
}
