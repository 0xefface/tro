using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1235 : Room
{
public Room1235()
: base(1235, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 33, 111, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 372, 216, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 161, 207, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 349, 213, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 171, 212, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 384, 104, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 4, 22, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 297, 104, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 125, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 122, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 122, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 122, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 124, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 124, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 88, 211, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 87, 221, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 267, 212, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 452, 211, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 555, 211, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 291, 221, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 488, 221, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 567, 222, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 166, 204, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 184, 211, 0, 1235));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 155, 211, 0, 1235));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1229;
                case RoomExit.South: return 1241;
                case RoomExit.East:  return 4135;
                case RoomExit.West:  return 1234;
                default: return 0;
            }
        }
}
}
