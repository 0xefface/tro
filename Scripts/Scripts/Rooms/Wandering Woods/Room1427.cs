using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1427 : Room
{
public Room1427()
: base(1427, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 121, 206, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 548, 318, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 603, 334, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 122, 212, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 567, 306, 6, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 45, 136, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 136, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 135, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 136, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 123, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 123, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 134, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 138, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 136, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 136, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 135, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 589, 132, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 132, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 132, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(235, 275, 102, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 250, 119, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 248, 144, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 257, 187, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 276, 240, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 299, 236, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 269, 181, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 256, 119, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 251, 124, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 251, 129, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 254, 143, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 258, 152, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 260, 163, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 671, 355, 0, 1427));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 585, 315, 0, 1427));



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
