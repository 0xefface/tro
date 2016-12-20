using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1403 : Room
{
public Room1403()
: base(1403, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 646, 101, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65527, 103, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 65480, 103, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 496, 106, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 197, 109, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 116, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 30, 293, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 86, 278, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 117, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 116, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 117, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 69, 285, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 125, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 62, 116, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 27, 119, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 251, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 399, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 427, 126, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 622, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 60, 284, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 126, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 176, 124, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 125, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 119, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 407, 104, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 118, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 119, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 114, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 114, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 123, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 123, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 125, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 125, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 333, 110, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 362, 145, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 415, 200, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 422, 253, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 569, 89, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 622, 113, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 327, 129, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 364, 155, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 391, 212, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 498, 233, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 337, 229, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 348, 250, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 402, 340, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 602, 255, 0, 1403));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 324, 117, 0, 1403));



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
