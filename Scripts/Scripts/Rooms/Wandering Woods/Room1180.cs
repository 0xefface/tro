using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1180 : Room
{
public Room1180()
: base(1180, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 138, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 150, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 201, 127, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 281, 140, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 622, 256, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 504, 244, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 307, 250, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 292, 308, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 205, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 340, 248, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 301, 248, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 27, 255, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 142, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 104, 290, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 183, 292, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 156, 74, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 620, 252, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 284, 246, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 16, 280, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 502, 254, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 104, 294, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 172, 312, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 141, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 140, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 140, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 140, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 137, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 144, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 144, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 151, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 151, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 59, 196, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 172, 195, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 205, 210, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 549, 255, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 319, 194, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 337, 191, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 370, 192, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 378, 231, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 413, 230, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 229, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 617, 236, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 51, 286, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 552, 180, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 625, 326, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 629, 185, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 565, 299, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 22, 200, 0, 1180));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 42, 231, 0, 1180));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1174;
                case RoomExit.South: return 1186;
                case RoomExit.East:  return 1181;
                case RoomExit.West:  return 1131;
                default: return 0;
            }
        }
}
}
