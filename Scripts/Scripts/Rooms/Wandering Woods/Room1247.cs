using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1247 : Room
{
public Room1247()
: base(1247, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 184, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 532, 226, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 577, 242, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 581, 234, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65526, 103, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 134, 103, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 275, 103, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(33009, 426, 25, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 125, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 125, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 124, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 125, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 365, 47, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 125, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 126, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 126, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(936, 40, 191, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(938, 26, 211, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(936, 17, 178, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(942, 172, 351, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(941, 27, 266, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(944, 70, 299, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 33, 281, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 65519, 157, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 8, 171, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 65478, 189, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 24, 259, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 25, 293, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 11, 201, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(960, 18, 303, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 179, 297, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 0, 161, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 20, 165, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 27, 171, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 49, 172, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 38, 167, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 577, 223, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 736, 106, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 835, 92, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(1304, 665, 92, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(1273, 378, 122, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(1282, 512, 74, 65507, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 66, 225, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 67, 280, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 129, 329, 0, 1247));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 218, 353, 0, 1247));



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
