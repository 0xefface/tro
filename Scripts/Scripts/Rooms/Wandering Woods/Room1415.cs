using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1415 : Room
{
public Room1415()
: base(1415, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 609, 321, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 588, 274, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 193, 104, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 234, 104, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 68, 115, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 65533, 120, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 526, 127, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 230, 105, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 616, 124, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 70, 187, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 574, 277, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 76, 193, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 44, 189, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 87, 188, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 126, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 126, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 119, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 298, 106, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 292, 131, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 292, 109, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 289, 156, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 275, 196, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 263, 233, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 288, 228, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 297, 176, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 298, 161, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 378, 216, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 490, 215, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 601, 215, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 570, 203, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 633, 276, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 473, 330, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 639, 178, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 620, 139, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 622, 278, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 523, 281, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 550, 277, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 580, 285, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 585, 277, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 626, 387, 0, 1415));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 65525, 252, 0, 1415));



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
