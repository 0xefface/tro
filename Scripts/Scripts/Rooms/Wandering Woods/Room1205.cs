using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1205 : Room
{
public Room1205()
: base(1205, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 418, 103, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 213, 102, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 334, 103, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 555, 107, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 19, 119, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 10, 324, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 501, 216, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 291, 156, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 292, 159, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 481, 231, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 461, 210, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 70, 332, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 186, 103, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 246, 118, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 38, 220, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 333, 230, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 582, 276, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 479, 276, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 183, 224, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 292, 224, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 275, 217, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 262, 226, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 114, 260, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 168, 260, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 222, 263, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 272, 265, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 363, 221, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 386, 269, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 337, 272, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 346, 265, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 358, 301, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 394, 315, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 571, 232, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 472, 233, 0, 1205));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 38, 260, 0, 1205));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4050;
                case RoomExit.South: return 1211;
                case RoomExit.East:  return 4100;
                case RoomExit.West:  return 1204;
                default: return 0;
            }
        }
}
}
