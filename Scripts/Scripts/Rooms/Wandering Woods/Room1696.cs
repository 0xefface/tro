using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1696 : Room
{
public Room1696()
: base(1696, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(203, 639, 325, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 391, 319, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 116, 315, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 590, 326, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 283, 317, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 307, 105, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 110, 136, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 554, 134, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 180, 127, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 107, 129, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 40, 138, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 419, 130, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 489, 137, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 547, 128, 0, 1696));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 624, 125, 0, 1696));



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
