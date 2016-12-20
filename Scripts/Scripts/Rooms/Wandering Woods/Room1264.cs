using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1264 : Room
{
public Room1264()
: base(1264, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 524, 135, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 363, 138, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 623, 141, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 136, 138, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 574, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 20, 157, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 260, 142, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 518, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 327, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 438, 226, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 30, 229, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 112, 250, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 189, 251, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 139, 243, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 62, 227, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 146, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 146, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 433, 222, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 142, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 41, 145, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 619, 131, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 326, 282, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 136, 254, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 421, 229, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 354, 319, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 138, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 142, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 438, 216, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 184, 289, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 44, 252, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 139, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 139, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 139, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 140, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 138, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 561, 324, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 139, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 137, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 137, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 144, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 141, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 14, 156, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 131, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 141, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 181, 226, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 713, 227, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 730, 216, 0, 1264));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 634, 241, 0, 1264));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
