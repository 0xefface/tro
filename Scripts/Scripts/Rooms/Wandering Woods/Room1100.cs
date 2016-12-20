using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1100 : Room
{
public Room1100()
: base(1100, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 527, 114, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 500, 256, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 457, 262, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 500, 250, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 427, 1, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 128, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 128, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 127, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 102, 121, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 125, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 206, 126, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 129, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 129, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 128, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 127, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 127, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 128, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 236, 141, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 317, 180, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 396, 298, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 158, 139, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 98, 138, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 42, 135, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 313, 142, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 353, 253, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 191, 161, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 259, 162, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 25, 156, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 113, 160, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 265, 145, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 90, 159, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 542, 330, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 640, 250, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 641, 319, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 336, 298, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 98, 165, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 198, 167, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 277, 169, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 244, 229, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(32949, 504, 233, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 13, 165, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 368, 323, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 322, 190, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 367, 291, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 439, 236, 0, 1100));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 410, 268, 0, 1100));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21949;
                case RoomExit.South: return 1101;
                case RoomExit.East:  return 1036;
                case RoomExit.West:  return 22017;
                default: return 0;
            }
        }
}
}
