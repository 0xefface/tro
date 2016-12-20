using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1113 : Room
{
public Room1113()
: base(1113, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 252, 105, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 643, 103, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 139, 103, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 72, 104, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 421, 122, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 529, 115, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 121, 107, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 530, 197, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 534, 198, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 123, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 124, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 200, 108, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 126, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 124, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 62, 65, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 470, 121, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 102, 197, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 251, 198, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 484, 181, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 512, 173, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 638, 174, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 380, 179, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 398, 179, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 213, 228, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 53, 231, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 229, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 508, 197, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 603, 201, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 597, 199, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 15, 201, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 45, 201, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 78, 199, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 352, 205, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 359, 201, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 541, 173, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 482, 173, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 190, 198, 0, 1113));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 606, 175, 0, 1113));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1107;
                case RoomExit.South: return 1120;
                case RoomExit.East:  return 1114;
                case RoomExit.West:  return 1112;
                default: return 0;
            }
        }
}
}
