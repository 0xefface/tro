using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3175 : Room
{
public Room3175()
: base(3175, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 101, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65527, 103, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 65480, 103, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 496, 106, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 197, 108, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 369, 226, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 379, 221, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 62, 116, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 27, 119, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 252, 118, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 399, 118, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 367, 126, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 456, 129, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 222, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 126, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 176, 124, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 406, 101, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 118, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 118, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 119, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 114, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 114, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 123, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 123, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 125, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 125, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 117, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 117, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 125, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 125, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 128, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 128, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 128, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 116, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 116, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 53, 185, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 176, 186, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 294, 188, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 310, 252, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 120, 218, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 332, 255, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 299, 257, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 229, 183, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 214, 216, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 23, 217, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 304, 322, 0, 3175));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 380, 322, 0, 3175));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3167;
                case RoomExit.South: return 3182;
                case RoomExit.East:  return 3176;
                case RoomExit.West:  return 3174;
                default: return 0;
            }
        }
}
}
