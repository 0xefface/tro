using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room16119 : Room
{
public Room16119()
: base(16119, "Wexfordshire Valley")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(185, 257, 288, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 118, 151, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 88, 153, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 148, 273, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 28, 83, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 145, 265, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 532, 103, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 45, 79, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(142, 514, 106, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 174, 102, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 503, 95, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 3, 80, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 78, 152, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 114, 147, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 253, 277, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 309, 279, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 118, 152, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 97, 140, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 205, 290, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 348, 102, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 108, 138, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(33008, 552, 17, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 487, 280, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 468, 242, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 462, 179, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 573, 178, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 636, 180, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 464, 286, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 528, 285, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 519, 223, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 527, 231, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 411, 217, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 400, 231, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 532, 208, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 625, 210, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 773, 107, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 618, 168, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 631, 159, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 580, 166, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 610, 155, 0, 16119));
this.AddRoomDecoration(RoomDecoration.FromCode(32834, 585, 165, 0, 16119));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 16111;
                case RoomExit.South: return 16130;
                case RoomExit.East:  return 16120;
                case RoomExit.West:  return 16118;
                default: return 0;
            }
        }
}
}
