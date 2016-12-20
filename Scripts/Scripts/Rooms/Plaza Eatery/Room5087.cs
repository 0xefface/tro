using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5087 : Room
{
public Room5087()
: base(5087, "Plaza Eatery")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 124, 170, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 343, 291, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 613, 456, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(85, 533, 153, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(86, 532, 154, 45, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 634, 452, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2936, 310, 290, 65459, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 574, 131, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 57, 57, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 573, 60, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 566, 94, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 506, 78, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 622, 137, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 471, 110, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 53, 90, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 99, 256, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 523, 255, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 91, 321, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 564, 323, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 533, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 560, 455, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 348, 324, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 3, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 56, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 81, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 133, 452, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 161, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 295, 455, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 242, 454, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 213, 453, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 326, 455, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 381, 456, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 402, 452, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 455, 452, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 480, 452, 0, 5087));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 547, 132, 0, 5087));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5072;
                case RoomExit.South: return 4012;
                case RoomExit.East:  return 5088;
                case RoomExit.West:  return 5086;
                default: return 0;
            }
        }
}
}
