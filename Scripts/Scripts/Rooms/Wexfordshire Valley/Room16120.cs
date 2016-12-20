using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room16120 : Room
{
public Room16120()
: base(16120, "Wexfordshire Valley")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(185, 54, 168, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(32910, 84, 77, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 5, 170, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 252, 241, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 24, 164, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 58, 166, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 2, 146, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(32941, 65486, 103, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 48, 154, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 25, 139, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 477, 56, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 548, 108, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 253, 242, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 41, 179, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 87, 181, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 280, 183, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 411, 186, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 525, 187, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 642, 187, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 529, 219, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 195, 146, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 194, 211, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 159, 218, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 146, 179, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 226, 215, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 352, 214, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 470, 217, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 583, 219, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 197, 105, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 184, 141, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 183, 134, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 175, 176, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 223, 184, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 122, 213, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 171, 289, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 174, 223, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 174, 225, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 186, 126, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(33008, 65449, 15, 0, 16120));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 16, 212, 0, 16120));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 16112;
                case RoomExit.South: return 16131;
                case RoomExit.East:  return 16121;
                case RoomExit.West:  return 16119;
                default: return 0;
            }
        }
}
}
