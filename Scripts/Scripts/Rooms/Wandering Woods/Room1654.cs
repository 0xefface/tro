using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1654 : Room
{
public Room1654()
: base(1654, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 588, 123, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 399, 141, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 150, 135, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 591, 132, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 313, 151, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 506, 142, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 141, 258, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 315, 254, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 269, 329, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 259, 329, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 73, 314, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 390, 235, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 30, 313, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 90, 251, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 613, 118, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 458, 358, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 513, 146, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 519, 140, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 528, 137, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 144, 130, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 339, 258, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 121, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 123, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 54, 132, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 133, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 138, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 136, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 135, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 340, 152, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 143, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 141, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 141, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 140, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 130, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 130, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 127, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 121, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 121, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 81, 195, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 536, 260, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 273, 247, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 632, 229, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 15, 125, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 70, 248, 0, 1654));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 7, 255, 0, 1654));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
