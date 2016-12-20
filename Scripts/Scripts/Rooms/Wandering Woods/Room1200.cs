using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1200 : Room
{
public Room1200()
: base(1200, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 409, 104, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 516, 123, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 281, 218, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 78, 276, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 55, 277, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 269, 225, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 279, 227, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 519, 111, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 101, 108, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 156, 31, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 275, 230, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 126, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 125, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 123, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 123, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32973, 308, 106, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(33015, 436, 174, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 409, 139, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 583, 187, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 356, 128, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 470, 178, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 484, 182, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 626, 220, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 500, 186, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 408, 169, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 427, 167, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 374, 146, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 333, 124, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 482, 210, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 555, 180, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 319, 123, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 623, 219, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 312, 113, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 630, 272, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 638, 234, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 598, 253, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 635, 262, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 617, 317, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 631, 294, 0, 1200));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 583, 316, 0, 1200));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4045;
                case RoomExit.South: return 1206;
                case RoomExit.East:  return 1201;
                case RoomExit.West:  return 1173;
                default: return 0;
            }
        }
}
}
