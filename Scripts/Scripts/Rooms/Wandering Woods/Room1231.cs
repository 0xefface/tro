using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1231 : Room
{
public Room1231()
: base(1231, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 530, 197, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 493, 208, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 475, 250, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 175, 277, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 304, 259, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 569, 242, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 553, 314, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 23, 240, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 83, 298, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 392, 259, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 347, 281, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 261, 274, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 56, 260, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 596, 272, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 593, 275, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 383, 276, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 585, 298, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 38, 274, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 88, 236, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 288, 102, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 218, 103, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(171, 305, 99, 65535, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 65513, 116, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(146, 182, 121, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 171, 123, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 198, 122, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 639, 313, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 646, 201, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 515, 216, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 520, 210, 0, 1231));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 552, 195, 0, 1231));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1225;
                case RoomExit.South: return 1237;
                case RoomExit.East:  return 1232;
                case RoomExit.West:  return 1230;
                default: return 0;
            }
        }
}
}
