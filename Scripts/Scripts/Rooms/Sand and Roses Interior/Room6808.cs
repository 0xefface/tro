using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6808 : Room
{
public Room6808()
: base(6808, "Sand and Roses Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 18, 156, 50, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 442, 11, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 180, 9, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 237, 51, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 540, 115, 100, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 203, 244, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 205, 254, 170, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2128, 206, 284, 220, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 76, 56, 40, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 318, 296, 200, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 322, 209, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 497, 173, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 376, 116, 30, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 108, 239, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 296, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2018, 11, 114, 50, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 361, 51, 0, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2006, 616, 121, 50, 6808));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 52, 180, 0, 6808));



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
