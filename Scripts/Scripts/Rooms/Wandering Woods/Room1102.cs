using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1102 : Room
{
public Room1102()
: base(1102, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 33, 111, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 376, 221, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 162, 190, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 384, 104, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 4, 22, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 297, 104, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 125, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 122, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 122, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 122, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 124, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 124, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 180, 187, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 585, 317, 0, 1102));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 510, 319, 0, 1102));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22026;
                case RoomExit.South: return 1105;
                case RoomExit.East:  return 1103;
                case RoomExit.West:  return 22034;
                default: return 0;
            }
        }
}
}
