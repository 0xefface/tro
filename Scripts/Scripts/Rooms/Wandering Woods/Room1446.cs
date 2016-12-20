using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1446 : Room
{
public Room1446()
: base(1446, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 440, 103, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 126, 102, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 226, 110, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 509, 115, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 437, 249, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 618, 315, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 561, 309, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 573, 314, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 437, 252, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 287, 2, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 126, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 113, 104, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 125, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 125, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 125, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 124, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 124, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 123, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 118, 252, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(943, 106, 264, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(932, 236, 336, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(945, 44, 241, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(940, 52, 169, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 65474, 178, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 65467, 103, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 189, 311, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(960, 58, 284, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 70, 324, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(33725, 23, 129, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 526, 95, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 527, 207, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 490, 111, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 607, 171, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 533, 197, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 465, 235, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 584, 277, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 84, 232, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 27, 322, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 109, 542, 0, 1446));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 220, 565, 0, 1446));



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
