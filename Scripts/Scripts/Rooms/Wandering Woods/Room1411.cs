using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1411 : Room
{
public Room1411()
: base(1411, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 110, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 335, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 184, 235, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 133, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 136, 244, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 188, 234, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 169, 221, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 132, 0, 1411));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 132, 0, 1411));



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
