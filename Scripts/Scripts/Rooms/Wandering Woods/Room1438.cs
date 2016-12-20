using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1438 : Room
{
public Room1438()
: base(1438, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(45, 380, 246, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 247, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 198, 118, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 127, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 115, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 335, 103, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 26, 126, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 117, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 117, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 117, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(947, 345, 299, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(932, 133, 286, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(33701, 622, 245, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(33710, 512, 295, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(944, 20, 197, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 566, 253, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 316, 270, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 70, 245, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 635, 227, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 31, 187, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 47, 208, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 626, 208, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 606, 245, 36, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(960, 62, 239, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 602, 281, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 329, 315, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 119, 295, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 392, 314, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 636, 254, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 15, 174, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 509, 269, 36, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 546, 256, 36, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 457, 266, 36, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(13, 65522, 166, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 236, 574, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 501, 574, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(7905, 555, 278, 0, 1438));
this.AddRoomDecoration(RoomDecoration.FromCode(40673, 198, 264, 0, 1438));



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
