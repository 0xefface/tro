using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1390 : Room
{
public Room1390()
: base(1390, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65523, 118, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 498, 129, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 362, 130, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 447, 139, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 616, 142, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 142, 133, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 213, 107, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 346, 138, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 139, 128, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 65, 134, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 44, 259, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 262, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 445, 266, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 313, 203, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 464, 262, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 161, 318, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 308, 203, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 131, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 136, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 611, 142, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 140, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 269, 132, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 14, 137, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 165, 330, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 66, 287, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 340, 207, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 131, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 137, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 149, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 160, 118, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 149, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 635, 142, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 137, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 132, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 132, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 134, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 134, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 136, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 131, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 233, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 618, 248, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 634, 221, 0, 1390));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 592, 237, 0, 1390));



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
