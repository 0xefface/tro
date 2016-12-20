using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6804 : Room
{
public Room6804()
: base(6804, "The Shifting Dune Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 125, 91, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 70, 141, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 438, 123, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 186, 273, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 25, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2048, 511, 189, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 564, 161, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 369, 124, 0, 6804));
this.AddRoomDecoration(RoomDecoration.FromCode(2047, 54, 169, 0, 6804));



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
