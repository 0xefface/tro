using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5027 : Room
{
public Room5027()
: base(5027, "Expeditionary Provisions")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 312, 44, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 249, 49, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 28, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2607, 365, 61, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 138, 12, 65395, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35722, 478, 204, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 603, 238, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2607, 283, 119, 69, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 456, 25, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 416, 220, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35722, 60, 14, 65386, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 505, 204, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 97, 3, 3, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 198, 199, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 526, 188, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 386, 208, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 23, 9, 65396, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 423, 172, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 226, 142, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 440, 145, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 226, 148, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35560, 150, 103, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35478, 182, 59, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2796, 114, 111, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 594, 1, 1, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 677, 33, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 534, 278, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 6, 197, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 34, 200, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35722, 310, 290, 65386, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35722, 310, 290, 65386, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 52, 191, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 82, 199, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 159, 190, 0, 5027));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 24, 211, 0, 5027));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5012;
                case RoomExit.South: return 5042;
                case RoomExit.East:  return 5028;
                case RoomExit.West:  return 5026;
                default: return 0;
            }
        }
}
}
