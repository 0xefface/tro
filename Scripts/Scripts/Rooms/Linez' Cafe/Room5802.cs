using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5802 : Room
{
public Room5802()
: base(5802, "Linez' Cafe")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 477, 12, 65437, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 93, 6, 65437, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 179, 117, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 505, 97, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2746, 432, 94, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(35516, 282, 100, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2747, 568, 94, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 132, 106, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 116, 102, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 46, 122, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 549, 121, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 477, 117, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65521, 118, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 124, 115, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 645, 114, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 506, 170, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 125, 299, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 483, 303, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(32854, 132, 153, 50, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(85, 127, 153, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(1545, 252, 91, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 574, 103, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 175, 116, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 618, 116, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(32831, 436, 102, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2747, 65513, 98, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 38, 289, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 225, 16, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 526, 7, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 304, 45, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(1587, 243, 94, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(34355, 594, 287, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 111, 149, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 167, 149, 0, 5802));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 58, 108, 0, 5802));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21449;
                case RoomExit.South: return 5805;
                case RoomExit.East:  return 21495;
                case RoomExit.West:  return 5801;
                default: return 0;
            }
        }
}
}
