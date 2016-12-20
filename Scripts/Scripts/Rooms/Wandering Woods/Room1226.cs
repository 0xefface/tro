using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1226 : Room
{
public Room1226()
: base(1226, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 78, 114, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 120, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 163, 182, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 268, 105, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 169, 187, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 298, 33, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 128, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 186, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 186, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 187, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 126, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 128, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 127, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 126, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 126, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 181, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 179, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 180, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 184, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 186, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 554, 212, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 401, 215, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 266, 216, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 146, 218, 0, 1226));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 36, 220, 0, 1226));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1220;
                case RoomExit.South: return 1232;
                case RoomExit.East:  return 1227;
                case RoomExit.West:  return 1225;
                default: return 0;
            }
        }
}
}
