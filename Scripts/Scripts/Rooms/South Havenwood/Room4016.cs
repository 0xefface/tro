using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4016 : Room
{
public Room4016()
: base(4016, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 116, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 102, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 413, 282, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 172, 192, 0, 4016));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 381, 109, 0, 4016));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4001;
                case RoomExit.South: return 4031;
                case RoomExit.East:  return 4017;
                case RoomExit.West:  return 4015;
                default: return 0;
            }
        }
}
}
