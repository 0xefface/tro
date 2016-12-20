using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1671 : Room
{
public Room1671()
: base(1671, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 557, 129, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 266, 136, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 416, 140, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 599, 144, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 536, 142, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 138, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 136, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 212, 143, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 485, 138, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 348, 238, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 511, 323, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 610, 202, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 355, 255, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 140, 221, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 255, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 106, 237, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 104, 227, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 371, 67, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 434, 123, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 138, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 142, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 135, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 143, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 99, 224, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 49, 257, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 594, 203, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 134, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 143, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 143, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 22, 147, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 146, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 136, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 136, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 136, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 135, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 420, 135, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 134, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 140, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 590, 203, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 471, 204, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 334, 217, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 311, 211, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 229, 245, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 258, 244, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 306, 246, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 341, 258, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 392, 248, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(134, 266, 210, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 261, 211, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 294, 211, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 262, 210, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 678, 305, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 654, 287, 0, 1671));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 656, 239, 0, 1671));



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
