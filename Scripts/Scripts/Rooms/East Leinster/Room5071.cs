using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5071 : Room
{
public Room5071()
: base(5071, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 574, 61, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 498, 82, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 601, 80, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 621, 115, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 673, 13, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65509, 12, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 550, 114, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(128, 176, 291, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 5, 84, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 25, 117, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 108, 80, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 31, 319, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 605, 102, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 75, 85, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 123, 80, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 629, 87, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 18, 98, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 619, 317, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 105, 268, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 535, 272, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 141, 11, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 503, 12, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 62, 238, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 110, 259, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 564, 249, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 678, 225, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 549, 38, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 89, 34, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 59, 57, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 581, 311, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 43, 306, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 15, 321, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 81, 317, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 617, 317, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 620, 296, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 281, 194, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 337, 195, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 319, 195, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 266, 184, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 266, 191, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 347, 187, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 340, 184, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 299, 195, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 284, 177, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 305, 177, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 326, 177, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 337, 181, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 291, 174, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 347, 174, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 323, 202, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 323, 181, 0, 5071));
this.AddRoomDecoration(RoomDecoration.FromCode(2746, 473, 69, 0, 5071));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5056;
                case RoomExit.South: return 5086;
                case RoomExit.East:  return 5072;
                case RoomExit.West:  return 5070;
                default: return 0;
            }
        }
}
}
