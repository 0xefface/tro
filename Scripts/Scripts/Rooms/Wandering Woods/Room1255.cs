using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1255 : Room
{
public Room1255()
: base(1255, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 89, 124, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 528, 123, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 302, 133, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 439, 138, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 619, 145, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 164, 138, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 565, 134, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 361, 145, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 278, 135, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 374, 134, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 508, 144, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 135, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 539, 252, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 13, 279, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 158, 240, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 136, 247, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 48, 278, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 496, 257, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 522, 271, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 144, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 144, 244, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 133, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 138, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 133, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 279, 144, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 138, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 189, 236, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 198, 243, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 144, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 131, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 132, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 134, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 143, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 143, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 134, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 183, 103, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 474, 104, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 398, 99, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 104, 89, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 35, 284, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 504, 272, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 550, 257, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 678, 331, 0, 1255));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 622, 310, 0, 1255));



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
