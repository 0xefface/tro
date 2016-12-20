using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1683 : Room
{
public Room1683()
: base(1683, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 283, 135, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 502, 137, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 516, 148, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 564, 143, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 400, 139, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 39, 144, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 191, 139, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 452, 142, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 88, 133, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 465, 225, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 132, 315, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 432, 221, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 609, 257, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 164, 240, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 43, 207, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 613, 270, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 250, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 176, 239, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 65, 213, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 181, 254, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 307, 255, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 120, 239, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 258, 195, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 143, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 139, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 139, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 140, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 139, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 258, 133, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 134, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 141, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 140, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 140, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 141, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 142, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 148, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 149, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 148, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 143, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 587, 142, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 143, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 130, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 130, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 90, 333, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 65513, 438, 0, 1683));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 65527, 592, 0, 1683));



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
