using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1101 : Room
{
public Room1101()
: base(1101, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 372, 103, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 184, 103, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 498, 115, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 431, 318, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 452, 315, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 445, 303, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 415, 322, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 156, 132, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 457, 106, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 19, 121, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 130, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 130, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 131, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 225, 118, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 122, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 121, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 116, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 116, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 343, 121, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 151, 254, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 314, 107, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32975, 269, 251, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 294, 139, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 403, 250, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 573, 252, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 289, 177, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 359, 152, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 350, 157, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 359, 157, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 340, 157, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 353, 155, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 314, 117, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 304, 306, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 367, 250, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 472, 256, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 653, 338, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 692, 259, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 485, 339, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 329, 140, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 351, 140, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 341, 122, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 262, 254, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 484, 284, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 375, 279, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 374, 312, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 217, 257, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 234, 273, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 238, 292, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 10, 173, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 38, 173, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 31, 177, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 251, 166, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 307, 168, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 608, 284, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 155, 333, 0, 1101));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 309, 120, 0, 1101));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1100;
                case RoomExit.South: return 1103;
                case RoomExit.East:  return 1042;
                case RoomExit.West:  return 22026;
                default: return 0;
            }
        }
}
}
