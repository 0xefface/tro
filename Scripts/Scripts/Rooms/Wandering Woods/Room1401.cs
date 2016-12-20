using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1401 : Room
{
public Room1401()
: base(1401, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 432, 107, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 629, 335, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 274, 355, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 50, 118, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 122, 127, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 531, 123, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 614, 117, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 581, 125, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 48, 259, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 68, 261, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 126, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 117, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 117, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 122, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 124, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 124, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 124, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 124, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 276, 109, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 306, 126, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32989, 307, 182, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 305, 226, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 287, 277, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 393, 279, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 291, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 306, 292, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 365, 294, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 400, 207, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 233, 216, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 320, 224, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 331, 197, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 309, 142, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 281, 121, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 416, 176, 0, 1401));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 300, 327, 0, 1401));



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
