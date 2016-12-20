using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5013 : Room
{
public Room5013()
: base(5013, "Spells of Fire")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 157, 59, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 164, 68, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 281, 49, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 346, 26, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 574, 157, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 629, 223, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 365, 165, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 376, 184, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2508, 6, 40, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(35381, 527, 168, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 275, 56, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 225, 33, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(35381, 125, 80, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2698, 419, 165, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 644, 149, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 584, 240, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 481, 242, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 376, 232, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 245, 187, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 261, 159, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 279, 222, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2522, 632, 160, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 128, 220, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 235, 207, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 527, 233, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2936, 310, 290, 65365, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 39, 179, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 28, 160, 0, 5013));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 626, 6, 65476, 5013));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2058;
                case RoomExit.South: return 5028;
                case RoomExit.East:  return 5014;
                case RoomExit.West:  return 5012;
                default: return 0;
            }
        }
}
}
