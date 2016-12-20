using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1191 : Room
{
public Room1191()
: base(1191, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 552, 133, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 495, 137, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 538, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 368, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 151, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 580, 137, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 37, 316, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 204, 254, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 404, 252, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 211, 249, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 84, 250, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 20, 208, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 98, 257, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 107, 251, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 404, 253, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 186, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 279, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 404, 128, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 321, 138, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 438, 135, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 417, 248, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 589, 320, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 338, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 149, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 144, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 145, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 145, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 137, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 137, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 602, 137, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 136, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 136, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 139, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 135, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 135, 0, 1191));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 156, 247, 0, 1191));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1185;
                case RoomExit.South: return 1197;
                case RoomExit.East:  return 1218;
                case RoomExit.West:  return 1190;
                default: return 0;
            }
        }
}
}
