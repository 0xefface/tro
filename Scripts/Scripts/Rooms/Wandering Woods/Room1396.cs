using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1396 : Room
{
public Room1396()
: base(1396, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(141, 54, 111, 20, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(142, 324, 102, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 582, 315, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 130, 148, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 136, 149, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 426, 105, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 156, 39, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(32941, 501, 105, 0, 1396));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 172, 107, 0, 1396));



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
