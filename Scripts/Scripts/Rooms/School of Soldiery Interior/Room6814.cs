using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6814 : Room
{
public Room6814()
: base(6814, "School of Soldiery Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 515, 39, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 153, 26, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 226, 6, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 311, 49, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 452, 7, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 379, 49, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2120, 313, 204, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 308, 202, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 307, 204, 60, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(34897, 315, 203, 30, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 492, 311, 50, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 212, 152, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 402, 188, 50, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 367, 153, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 248, 187, 50, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 380, 131, 0, 6814));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 165, 306, 0, 6814));



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
