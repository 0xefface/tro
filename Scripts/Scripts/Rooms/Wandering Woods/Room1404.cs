using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1404 : Room
{
public Room1404()
: base(1404, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 346, 101, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 145, 111, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 472, 115, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 365, 236, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 355, 237, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 601, 114, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 113, 344, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 65531, 368, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 9, 522, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 65479, 173, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(1593, 4, 156, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(34360, 3, 147, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(1590, 65535, 151, 0, 1404));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 7, 150, 0, 1404));


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
