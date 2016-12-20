using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1222 : Room
{
public Room1222()
: base(1222, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(176, 72, 103, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 110, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 484, 110, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 133, 142, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 478, 314, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 549, 309, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 499, 310, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 309, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 137, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 282, 103, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 292, 47, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 144, 143, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 543, 334, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 636, 323, 0, 1222));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 456, 323, 0, 1222));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1216;
                case RoomExit.South: return 1228;
                case RoomExit.East:  return 1223;
                case RoomExit.West:  return 1221;
                default: return 0;
            }
        }
}
}
