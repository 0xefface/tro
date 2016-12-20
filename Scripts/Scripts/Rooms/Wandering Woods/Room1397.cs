using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1397 : Room
{
public Room1397()
: base(1397, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(114, 202, 210, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 200, 213, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 230, 213, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 558, 96, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(32941, 65396, 104, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 273, 17, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 406, 102, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 160, 213, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 594, 101, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 618, 101, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 65530, 90, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 196, 213, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 612, 121, 0, 1397));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 54, 113, 0, 1397));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
