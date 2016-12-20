using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5059 : Room
{
public Room5059()
: base(5059, "Bloated Swine Tavern")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 147, 12, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 65497, 112, 65486, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2524, 67, 133, 100, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 221, 50, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 408, 54, 20, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 403, 72, 20, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 304, 80, 70, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 308, 93, 90, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 169, 176, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 377, 175, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 185, 148, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 393, 147, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 453, 203, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 375, 183, 90, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 160, 161, 90, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(35383, 65499, 133, 80, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 306, 137, 90, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2700, 156, 219, 130, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 301, 116, 120, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 131, 182, 130, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 460, 196, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 465, 197, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 187, 191, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 702, 18, 65520, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 161, 187, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 39, 245, 36, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 344, 203, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 69, 202, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 647, 329, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 651, 165, 0, 5059));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 735, 322, 0, 5059));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5044;
                case RoomExit.South: return 5074;
                case RoomExit.East:  return 5058;
                case RoomExit.West:  return 3024;
                default: return 0;
            }
        }
}
}
