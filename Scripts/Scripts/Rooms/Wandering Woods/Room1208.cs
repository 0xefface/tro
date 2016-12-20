using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1208 : Room
{
public Room1208()
: base(1208, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 514, 109, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 237, 227, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 134, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 134, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 65520, 196, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 134, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 107, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 300, 37, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 54, 134, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 242, 231, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 306, 108, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 301, 135, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 301, 110, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 321, 226, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 299, 227, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 295, 183, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 293, 158, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 310, 199, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 20, 323, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 47, 334, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 634, 264, 0, 1208));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 671, 272, 0, 1208));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1202;
                case RoomExit.South: return 1214;
                case RoomExit.East:  return 1209;
                case RoomExit.West:  return 1207;
                default: return 0;
            }
        }
}
}
