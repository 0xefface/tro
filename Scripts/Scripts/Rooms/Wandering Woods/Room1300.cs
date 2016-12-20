using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1300 : Room
{
public Room1300()
: base(1300, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 109, 120, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 120, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 324, 122, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 564, 169, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 427, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 97, 129, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 572, 149, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 148, 130, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 214, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 126, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 526, 239, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 620, 127, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 126, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 591, 251, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 590, 325, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 50, 293, 9, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 264, 223, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 430, 183, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 160, 298, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 83, 324, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 306, 0, 20, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 614, 271, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(218, 275, 35, 2, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 144, 299, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 435, 130, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 319, 119, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 427, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 261, 127, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 7, 81, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 561, 321, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 125, 306, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 183, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 101, 314, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 249, 221, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 374, 316, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 110, 315, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 210, 315, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 374, 122, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 525, 352, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 68, 271, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 126, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 96, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 121, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 178, 129, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 127, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 127, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 128, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 127, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 126, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 276, 229, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 252, 232, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 247, 217, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 85, 216, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 387, 218, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 607, 218, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 462, 218, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 400, 219, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 560, 230, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 160, 226, 0, 1300));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 12, 233, 0, 1300));



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
