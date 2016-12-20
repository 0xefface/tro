using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5086 : Room
{
public Room5086()
: base(5086, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 629, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 14, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 42, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 92, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 601, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 550, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 120, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 170, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 523, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 472, 465, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 198, 455, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 390, 455, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 247, 455, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(35303, 442, 455, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 92, 333, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 552, 332, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 222, 314, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 419, 314, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 106, 3, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 527, 5, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 83, 36, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 571, 32, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 578, 68, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 41, 80, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 147, 65, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 486, 56, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 505, 27, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 114, 29, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 11, 123, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 45, 117, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 86, 111, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 126, 105, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 159, 84, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 184, 60, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 423, 60, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 449, 85, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 490, 99, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 531, 107, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 573, 112, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 618, 114, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 601, 335, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 35, 306, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 155, 275, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 90, 262, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 536, 262, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 577, 234, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 87, 229, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 135, 257, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 58, 124, 0, 5086));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 547, 118, 0, 5086));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5071;
                case RoomExit.South: return 4011;
                case RoomExit.East:  return 5087;
                case RoomExit.West:  return 5085;
                default: return 0;
            }
        }
}
}
