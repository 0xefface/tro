using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1443 : Room
{
public Room1443()
: base(1443, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 501, 112, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 127, 137, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 348, 233, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 519, 291, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 318, 229, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 423, 134, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 116, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 126, 138, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 273, 116, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 514, 301, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 515, 300, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 412, 134, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 134, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 134, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 134, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 117, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 119, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 572, 237, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 417, 238, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 171, 237, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 294, 237, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 490, 268, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 487, 287, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 264, 268, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 263, 287, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 336, 233, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 381, 286, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 347, 286, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 388, 237, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 183, 323, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 138, 323, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 623, 278, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 77, 316, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 161, 103, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65531, 333, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 38, 306, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 102, 294, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 152, 102, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 243, 315, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 366, 105, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(32968, 689, 332, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 498, 231, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 603, 300, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 54, 245, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 112, 35, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 123, 146, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 132, 106, 0, 1443));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 93, 117, 0, 1443));



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
