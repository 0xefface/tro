using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1118 : Room
{
public Room1118()
: base(1118, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 524, 115, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 130, 117, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 175, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 66, 188, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 65494, 125, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 203, 191, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 518, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 208, 24, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 15, 181, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 102, 180, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 130, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 132, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 132, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 133, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 634, 131, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 31, 180, 0, 1118));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 5, 195, 0, 1118));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22049;
                case RoomExit.South: return 1125;
                case RoomExit.East:  return 1119;
                case RoomExit.West:  return 22083;
                default: return 0;
            }
        }
}
}
