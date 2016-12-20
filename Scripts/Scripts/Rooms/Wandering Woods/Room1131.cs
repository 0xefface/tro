using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1131 : Room
{
public Room1131()
: base(1131, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 277, 102, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 123, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 89, 146, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 421, 220, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 420, 237, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 96, 142, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 550, 326, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65411, 105, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 430, 236, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 122, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 122, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 123, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 123, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 124, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 124, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 123, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 123, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 124, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 618, 125, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 126, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 102, 198, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 265, 198, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 425, 197, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 558, 200, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 167, 230, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 281, 229, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 390, 230, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 523, 231, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 620, 232, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 359, 199, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 13, 201, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 40, 231, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 113, 199, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 530, 200, 0, 1131));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 650, 288, 0, 1131));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1124;
                case RoomExit.South: return 1139;
                case RoomExit.East:  return 1180;
                case RoomExit.West:  return 1130;
                default: return 0;
            }
        }
}
}
