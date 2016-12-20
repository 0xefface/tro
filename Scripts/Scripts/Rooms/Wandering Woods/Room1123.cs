using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1123 : Room
{
public Room1123()
: base(1123, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 505, 110, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 184, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 532, 226, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 512, 215, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 531, 216, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65526, 103, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 134, 103, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 326, 103, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 510, 103, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(33009, 426, 25, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 125, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 125, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 124, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 125, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 365, 47, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 125, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 126, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 126, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 88, 180, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 57, 178, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 200, 193, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 207, 182, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 269, 204, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 275, 243, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 287, 223, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 215, 187, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 303, 245, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 196, 209, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 179, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 104, 208, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 216, 183, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 24, 206, 0, 1123));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 138, 179, 0, 1123));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1116;
                case RoomExit.South: return 1130;
                case RoomExit.East:  return 1124;
                case RoomExit.West:  return 1122;
                default: return 0;
            }
        }
}
}
