using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1444 : Room
{
public Room1444()
: base(1444, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 84, 115, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 381, 110, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 583, 297, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 544, 214, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 130, 202, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 142, 206, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 110, 202, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 321, 104, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 53, 123, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 262, 46, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 316, 103, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 196, 316, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 123, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 122, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 122, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 123, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 122, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(33722, 705, 103, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 577, 78, 65511, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(33703, 588, 115, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(33706, 624, 133, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 518, 105, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 579, 129, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 562, 116, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 587, 129, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 596, 122, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 637, 133, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 586, 131, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 264, 213, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 599, 131, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 497, 200, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32989, 516, 172, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 378, 209, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 65529, 215, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 157, 211, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(32981, 91, 211, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 45, 288, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 65495, 326, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65519, 321, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65489, 316, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 196, 252, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 496, 245, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 469, 243, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 517, 139, 0, 1444));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 513, 154, 0, 1444));



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
