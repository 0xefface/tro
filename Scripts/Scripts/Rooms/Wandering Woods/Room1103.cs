using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1103 : Room
{
public Room1103()
: base(1103, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 298, 103, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 476, 248, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 414, 266, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 90, 318, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 144, 320, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 463, 250, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 270, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 420, 52, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 536, 108, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 506, 259, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 448, 278, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 97, 293, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 51, 104, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 15, 103, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 74, 279, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 125, 299, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 478, 233, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 512, 240, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 119, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 125, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 126, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 184, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 125, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 125, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 124, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 122, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 117, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 120, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 121, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 434, 186, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 332, 114, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 383, 115, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 358, 105, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 525, 187, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 386, 154, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 615, 188, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 351, 239, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 356, 240, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 435, 244, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 437, 249, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 657, 190, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 476, 188, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 540, 188, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 366, 116, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 406, 130, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 393, 123, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 561, 219, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 582, 185, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 366, 216, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 380, 156, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 116, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 379, 120, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 343, 126, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 493, 223, 0, 1103));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 645, 218, 0, 1103));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1101;
                case RoomExit.South: return 1106;
                case RoomExit.East:  return 1150;
                case RoomExit.West:  return 1102;
                default: return 0;
            }
        }
}
}
