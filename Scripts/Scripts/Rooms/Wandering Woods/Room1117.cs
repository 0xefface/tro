using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1117 : Room
{
public Room1117()
: base(1117, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 409, 104, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 516, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 281, 218, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 136, 273, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 120, 273, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 269, 225, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 279, 227, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 519, 111, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 101, 108, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 156, 31, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 275, 230, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 126, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 125, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 123, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 123, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 616, 125, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 382, 111, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 390, 115, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 360, 115, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 586, 128, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 565, 110, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 484, 249, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 620, 120, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 568, 212, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 666, 237, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 645, 227, 0, 1117));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 652, 223, 0, 1117));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1111;
                case RoomExit.South: return 1124;
                case RoomExit.East:  return 1168;
                case RoomExit.West:  return 1116;
                default: return 0;
            }
        }
}
}
