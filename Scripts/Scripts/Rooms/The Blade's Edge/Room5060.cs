using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5060 : Room
{
public Room5060()
: base(5060, "The Blade's Edge")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 184, 35, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 231, 42, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 213, 53, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 238, 61, 10, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 279, 57, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 371, 23, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 394, 146, 100, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 235, 147, 65516, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 525, 142, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 3, 319, 65516, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 259, 218, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 330, 214, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2696, 156, 101, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 234, 184, 20, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 522, 158, 20, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2541, 311, 172, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2544, 322, 179, 20, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 30, 325, 65516, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 310, 112, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 372, 197, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 465, 182, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 492, 3, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 561, 144, 100, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 596, 30, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 608, 127, 65466, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 508, 189, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 165, 199, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 288, 230, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 547, 227, 0, 5060));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 545, 189, 0, 5060));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5045;
                case RoomExit.South: return 5075;
                case RoomExit.East:  return 5061;
                case RoomExit.West:  return 1035;
                default: return 0;
            }
        }
}
}
