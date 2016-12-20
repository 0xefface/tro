using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6074 : Room
{
public Room6074()
: base(6074, "The Ebony Crystal Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2116, 117, 130, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 345, 99, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 332, 217, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 172, 28, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 242, 6, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2111, 559, 144, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 328, 108, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 217, 52, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 449, 52, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 24, 120, 65516, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2544, 36, 124, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 528, 95, 65516, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 581, 105, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2148, 65405, 303, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2125, 335, 218, 65, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(34911, 607, 145, 14, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2130, 331, 109, 20, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 54, 223, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2161, 141, 55, 0, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2142, 1, 224, 50, 6074));
this.AddRoomDecoration(RoomDecoration.FromCode(2102, 446, 213, 0, 6074));



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
