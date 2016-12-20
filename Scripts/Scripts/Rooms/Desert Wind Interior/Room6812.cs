using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6812 : Room
{
public Room6812()
: base(6812, "Desert Wind Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 458, 21, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 135, 1, 25, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 449, 65510, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 504, 116, 50, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 69, 112, 30, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 162, 86, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 545, 65515, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 348, 3, 25, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 381, 171, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 383, 172, 34, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2128, 383, 172, 65, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2221, 579, 166, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(34895, 384, 172, 4, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 25, 74, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 455, 180, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 236, 20, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 300, 213, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 187, 317, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 460, 302, 0, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 30, 27, 50, 6812));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 481, 186, 0, 6812));



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
