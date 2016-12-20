using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1672 : Room
{
public Room1672()
: base(1672, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 315, 138, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 569, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 17, 153, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 371, 143, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 61, 146, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 288, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 269, 325, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 334, 320, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 426, 208, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 81, 202, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 12, 223, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 191, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 179, 328, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 233, 250, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 138, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 138, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 135, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 138, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 135, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 15, 279, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 41, 291, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 26, 200, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 278, 237, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 83, 200, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 503, 133, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 46, 145, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 144, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 270, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 142, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 139, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 55, 204, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 153, 183, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 141, 180, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 212, 116, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 200, 154, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 207, 155, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 208, 129, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 101, 203, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 135, 203, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 208, 257, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 406, 222, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(137, 393, 206, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 510, 319, 0, 1672));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 371, 207, 0, 1672));



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
