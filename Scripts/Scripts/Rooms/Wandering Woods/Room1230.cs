using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1230 : Room
{
public Room1230()
: base(1230, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 414, 266, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 48, 225, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 68, 223, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 424, 242, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 270, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 506, 259, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 448, 278, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 99, 228, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 51, 104, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 85, 275, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 72, 246, 2, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 112, 217, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 478, 233, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 512, 240, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 307, 103, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(171, 272, 94, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 83, 124, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(155, 570, 128, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(163, 599, 128, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 30, 110, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 604, 266, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 588, 266, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 605, 320, 0, 1230));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 600, 255, 0, 1230));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1224;
                case RoomExit.South: return 1236;
                case RoomExit.East:  return 1231;
                case RoomExit.West:  return 1264;
                default: return 0;
            }
        }
}
}
