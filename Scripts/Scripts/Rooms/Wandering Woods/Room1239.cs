using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1239 : Room
{
public Room1239()
: base(1239, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 524, 115, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 130, 117, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 175, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 22, 204, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 69, 182, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 203, 191, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 518, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 208, 24, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 34, 204, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 50, 206, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 130, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 132, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 132, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 133, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 634, 131, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 573, 218, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 432, 218, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 97, 220, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 237, 219, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 47, 250, 0, 1239));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 74, 260, 0, 1239));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1233;
                case RoomExit.South: return 1245;
                case RoomExit.East:  return 1240;
                case RoomExit.West:  return 1238;
                default: return 0;
            }
        }
}
}
