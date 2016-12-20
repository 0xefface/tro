using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1125 : Room
{
public Room1125()
: base(1125, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 104, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 493, 113, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 54, 178, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 527, 190, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 310, 290, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 287, 293, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 417, 46, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 532, 191, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 388, 275, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 453, 285, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 523, 188, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 93, 184, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 620, 186, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 339, 281, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 127, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 128, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 258, 127, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 125, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 124, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 440, 171, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 426, 163, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 588, 161, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 489, 164, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 507, 165, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 317, 195, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 310, 184, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 218, 254, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 208, 215, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 190, 211, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 216, 266, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 330, 255, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 455, 185, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 454, 163, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 308, 266, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 513, 183, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 561, 186, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 73, 177, 0, 1125));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 39, 188, 0, 1125));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1118;
                case RoomExit.South: return 1133;
                case RoomExit.East:  return 1126;
                case RoomExit.West:  return 22092;
                default: return 0;
            }
        }
}
}
