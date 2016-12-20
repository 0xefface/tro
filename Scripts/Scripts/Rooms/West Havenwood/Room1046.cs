using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1046 : Room
{
public Room1046()
: base(1046, "West Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 322, 102, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 589, 271, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 251, 229, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 254, 214, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 302, 215, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 336, 213, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 290, 223, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 340, 222, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 251, 219, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 238, 226, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 201, 220, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 254, 209, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 287, 205, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 216, 211, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 186, 213, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 215, 202, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 453, 170, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 490, 167, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 140, 150, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 300, 262, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32978, 90, 260, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 477, 263, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 607, 265, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32941, 609, 104, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 171, 61, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 609, 109, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 298, 101, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 529, 84, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 526, 106, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 534, 336, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32908, 72, 102, 10, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(141, 29, 96, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 390, 280, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 390, 303, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 109, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 109, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 6, 280, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 105, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 105, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 105, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 109, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 109, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 161, 307, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 200, 308, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 146, 252, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 217, 249, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 137, 307, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 176, 240, 0, 1046));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 176, 251, 0, 1046));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1040;
                case RoomExit.South: return 1154;
                case RoomExit.East:  return 1047;
                case RoomExit.West:  return 1045;
                default: return 0;
            }
        }
}
}
