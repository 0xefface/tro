using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6044 : Room
{
public Room6044()
: base(6044, "Straight Off The Loom Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 64, 101, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 323, 334, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 551, 200, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2111, 562, 116, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 51, 227, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 169, 26, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 483, 39, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 430, 108, 65516, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2136, 1, 228, 48, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 226, 108, 65516, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 322, 335, 65, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 205, 125, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 409, 126, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 600, 201, 65521, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 601, 201, 11, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 270, 100, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 387, 110, 10, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 613, 117, 10, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 317, 214, 0, 6044));
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 321, 215, 65, 6044));



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
