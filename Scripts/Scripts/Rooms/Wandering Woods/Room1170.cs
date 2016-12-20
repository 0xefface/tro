using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1170 : Room
{
public Room1170()
: base(1170, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 549, 126, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 260, 129, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 508, 142, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 604, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 22, 151, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 288, 139, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 383, 131, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 477, 146, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 75, 130, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 217, 200, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 198, 208, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 488, 251, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 284, 200, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 210, 202, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 325, 107, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 90, 124, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 264, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 113, 253, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 575, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 255, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 95, 261, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 546, 143, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 262, 205, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 281, 197, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 500, 247, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 139, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 138, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 364, 131, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 131, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 131, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 146, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 141, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 142, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 116, 203, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 271, 209, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 246, 208, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 414, 214, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 22, 204, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 429, 292, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 277, 211, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 169, 208, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 308, 208, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 461, 247, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 502, 254, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 522, 272, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 307, 281, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 352, 250, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 337, 240, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 180, 241, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 79, 240, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 10, 239, 0, 1170));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 426, 333, 0, 1170));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1164;
                case RoomExit.South: return 1176;
                case RoomExit.East:  return 1171;
                case RoomExit.West:  return 1169;
                default: return 0;
            }
        }
}
}
