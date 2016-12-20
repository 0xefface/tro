using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1651 : Room
{
public Room1651()
: base(1651, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 536, 148, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 612, 152, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 353, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 415, 141, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 396, 263, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 165, 213, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 137, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 256, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 219, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 126, 214, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 214, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 27, 215, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 102, 214, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 87, 211, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 600, 289, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 152, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 118, 237, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 73, 211, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 222, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 182, 235, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 198, 223, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 238, 235, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 569, 219, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 547, 208, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 413, 259, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 397, 244, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 220, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 41, 206, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 631, 293, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 273, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 614, 291, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 571, 206, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 147, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 128, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 137, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 301, 127, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 127, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 139, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 68, 216, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 218, 316, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 65531, 319, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 261, 242, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 279, 233, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 205, 229, 0, 1651));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 210, 216, 0, 1651));



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
