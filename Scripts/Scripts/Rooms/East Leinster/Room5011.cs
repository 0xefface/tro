using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5011 : Room
{
public Room5011()
: base(5011, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35304, 133, 56, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 614, 56, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 249, 32, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 491, 36, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 96, 43, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 655, 47, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 33, 63, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 613, 64, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 101, 60, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 162, 61, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 218, 60, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 263, 58, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 550, 62, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 475, 62, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 76, 76, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 601, 67, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 499, 68, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 196, 56, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 570, 99, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 156, 68, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 59, 99, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 249, 90, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 184, 122, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 69, 132, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 591, 115, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 680, 145, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 4, 161, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 260, 83, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 249, 107, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 232, 122, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 211, 139, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 142, 170, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 107, 181, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 69, 188, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 34, 195, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 479, 78, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 492, 101, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 506, 124, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 529, 143, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 559, 156, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 593, 165, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 633, 167, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 185, 158, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 29, 158, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 32, 195, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 113, 130, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 533, 282, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 657, 167, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 180, 90, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 56, 111, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 607, 85, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 561, 98, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7905, 85, 195, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 620, 110, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 102, 282, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7905, 134, 171, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(40673, 596, 165, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 216, 137, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(40672, 524, 142, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 569, 336, 0, 5011));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 61, 333, 0, 5011));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2056;
                case RoomExit.South: return 5026;
                case RoomExit.East:  return 5012;
                case RoomExit.West:  return 5010;
                default: return 0;
            }
        }
}
}
