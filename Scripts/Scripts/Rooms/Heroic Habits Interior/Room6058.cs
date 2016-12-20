using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6058 : Room
{
public Room6058()
: base(6058, "Heroic Habits Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2120, 312, 155, 65446, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 123, 53, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 509, 263, 150, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 558, 56, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 509, 360, 50, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2315, 510, 293, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(34899, 456, 315, 50, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 228, 50, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 396, 314, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2315, 98, 293, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 96, 310, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2006, 602, 107, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2018, 33, 108, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 96, 254, 150, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 312, 147, 65436, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 239, 156, 65506, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 312, 165, 40, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2135, 316, 154, 65476, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2131, 362, 157, 65506, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2153, 191, 165, 40, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 244, 162, 10, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 314, 175, 80, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 444, 49, 0, 6058));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 333, 92, 0, 6058));



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
