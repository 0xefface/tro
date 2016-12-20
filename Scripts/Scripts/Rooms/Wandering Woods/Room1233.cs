using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1233 : Room
{
public Room1233()
: base(1233, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 87, 110, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 66, 254, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 55, 247, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 482, 179, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 518, 185, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 412, 167, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 455, 248, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 364, 202, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 391, 198, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 394, 205, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 259, 106, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 542, 105, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 176, 103, 0, 1233));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 8, 344, 0, 1233));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1227;
                case RoomExit.South: return 1239;
                case RoomExit.East:  return 1234;
                case RoomExit.West:  return 1232;
                default: return 0;
            }
        }
}
}
