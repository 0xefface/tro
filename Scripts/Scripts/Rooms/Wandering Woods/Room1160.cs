using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1160 : Room
{
public Room1160()
: base(1160, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 116, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 415, 262, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 416, 275, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 102, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 175, 188, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 171, 190, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 381, 109, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 400, 174, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 411, 184, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 520, 173, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 599, 172, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 288, 199, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 279, 190, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 238, 242, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 264, 237, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 277, 218, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 251, 219, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 243, 224, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 230, 230, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 48, 301, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 222, 281, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 47, 313, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 86, 260, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 41, 236, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 13, 116, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 626, 252, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 286, 252, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 622, 267, 0, 1160));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 627, 264, 0, 1160));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1154;
                case RoomExit.South: return 1166;
                case RoomExit.East:  return 1161;
                case RoomExit.West:  return 1159;
                default: return 0;
            }
        }
}
}
