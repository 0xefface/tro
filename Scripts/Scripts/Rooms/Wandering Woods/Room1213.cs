using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1213 : Room
{
public Room1213()
: base(1213, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 84, 115, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 437, 152, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 443, 153, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 440, 149, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 130, 223, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 118, 224, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 217, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 321, 104, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 53, 123, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 262, 46, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 316, 103, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 193, 316, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 123, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 122, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 122, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 123, 0, 1213));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 122, 0, 1213));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1207;
                case RoomExit.South: return 1219;
                case RoomExit.East:  return 1214;
                case RoomExit.West:  return 1212;
                default: return 0;
            }
        }
}
}
