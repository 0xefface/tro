using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1538 : Room
{
public Room1538()
: base(1538, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 536, 148, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 537, 157, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 353, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 415, 141, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 523, 252, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 526, 258, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 147, 221, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 214, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 27, 215, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 121, 236, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 104, 227, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 567, 157, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 629, 320, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 555, 238, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 100, 225, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 614, 291, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 537, 153, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 585, 217, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 128, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 137, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 301, 127, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 127, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 139, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 137, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 147, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 155, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(136, 474, 261, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 550, 239, 0, 1538));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 380, 229, 0, 1538));



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
