using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1246 : Room
{
public Room1246()
: base(1246, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 419, 104, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 105, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 586, 113, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 94, 273, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 113, 274, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65512, 7, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 224, 104, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 267, 105, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 443, 111, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33702, 599, 199, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33700, 391, 338, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33701, 532, 228, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 518, 243, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 600, 188, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 571, 207, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 521, 221, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 582, 230, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 574, 275, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(33726, 523, 269, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 259, 316, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 287, 302, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 314, 289, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 216, 306, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 612, 179, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 627, 175, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 604, 187, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 581, 187, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 503, 250, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 411, 277, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 406, 231, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 390, 239, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 372, 249, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 355, 261, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 342, 273, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 329, 284, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 277, 315, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 292, 303, 0, 1246));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 309, 295, 0, 1246));



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
