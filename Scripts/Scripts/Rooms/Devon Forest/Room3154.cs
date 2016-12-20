using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3154 : Room
{
public Room3154()
: base(3154, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 646, 101, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65527, 103, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 65480, 103, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 496, 106, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 197, 108, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 116, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 30, 293, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 86, 278, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 117, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 116, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 117, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 69, 285, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 125, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 62, 116, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 27, 119, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 252, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 399, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 427, 126, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 622, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 60, 284, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 126, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 176, 124, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 125, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 119, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 407, 102, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 118, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 119, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 114, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 114, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 123, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 123, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 125, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 125, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 341, 125, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 339, 151, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 346, 101, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 340, 104, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 322, 201, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 308, 232, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 334, 232, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 346, 180, 0, 3154));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 346, 153, 0, 3154));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3151;
                case RoomExit.South: return 3157;
                case RoomExit.East:  return 3155;
                case RoomExit.West:  return 3153;
                default: return 0;
            }
        }
}
}
