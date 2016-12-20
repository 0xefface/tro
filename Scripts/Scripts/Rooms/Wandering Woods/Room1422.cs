using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1422 : Room
{
public Room1422()
: base(1422, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 477, 102, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 139, 103, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 105, 102, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 424, 135, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 666, 131, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 50, 121, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 24, 321, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 101, 319, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 60, 349, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 106, 320, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 145, 319, 6, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 45, 136, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 136, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 135, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 136, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 123, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 123, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 134, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 138, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 136, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 136, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 135, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 589, 132, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 132, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 132, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 265, 104, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 259, 129, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 258, 111, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 257, 153, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 293, 225, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 278, 236, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 301, 236, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 264, 228, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 177, 183, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 270, 180, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 372, 187, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 493, 189, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 583, 188, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(32981, 634, 188, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 59, 182, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 609, 219, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 544, 220, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 439, 219, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 325, 215, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 220, 215, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 109, 214, 0, 1422));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 16, 215, 0, 1422));



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
