using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room16131 : Room
{
public Room16131()
: base(16131, "Wexfordshire Valley")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(174, 328, 104, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 402, 174, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 68, 103, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32828, 48, 334, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 65445, 86, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(142, 262, 101, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 157, 103, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 183, 144, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 169, 155, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 148, 126, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 228, 160, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 258, 170, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 278, 189, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 306, 188, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 286, 174, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 293, 191, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 347, 292, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 336, 278, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 327, 252, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 271, 161, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 242, 290, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 191, 301, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 247, 307, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 142, 316, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 223, 288, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 604, 320, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 10, 126, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 1, 115, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 19, 115, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 35, 109, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 50, 112, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 5, 128, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 19, 118, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 28, 114, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 11, 122, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 12, 216, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 40, 223, 0, 16131));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 65516, 200, 0, 16131));

base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 16120;
                case RoomExit.South: return 5201;
                case RoomExit.East:  return 16132;
                case RoomExit.West:  return 16130;
                default: return 0;
            }
        }
}
}
