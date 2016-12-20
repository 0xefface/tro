using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5070 : Room
{
public Room5070()
: base(5070, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(24, 544, 260, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 111, 261, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 222, 124, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 554, 144, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 98, 131, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 613, 145, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 31, 131, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 498, 142, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 157, 129, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 437, 140, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 510, 101, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 103, 86, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 241, 101, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 379, 84, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65490, 115, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35515, 260, 115, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2746, 397, 116, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 514, 118, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 640, 104, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 311, 86, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 317, 44, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 328, 105, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 313, 256, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 348, 295, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 59, 319, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 33, 160, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 604, 309, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 622, 164, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 211, 155, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 160, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 609, 168, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 281, 39, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 263, 261, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 432, 233, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 332, 274, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 310, 291, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 115, 118, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 536, 119, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 117, 320, 0, 5070));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 538, 321, 0, 5070));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5055;
                case RoomExit.South: return 5085;
                case RoomExit.East:  return 5071;
                case RoomExit.West:  return 5069;
                default: return 0;
            }
        }
}
}
