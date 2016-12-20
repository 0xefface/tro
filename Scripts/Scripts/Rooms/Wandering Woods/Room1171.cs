using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1171 : Room
{
public Room1171()
: base(1171, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 353, 128, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 508, 130, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 105, 134, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 522, 139, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 220, 136, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 111, 138, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 459, 138, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 571, 134, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 45, 143, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 286, 132, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 131, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 133, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 597, 139, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 600, 209, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 445, 264, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 330, 239, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 290, 225, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 186, 227, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 39, 258, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 159, 210, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 221, 222, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 229, 221, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 366, 237, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 346, 251, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 608, 209, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 269, 217, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 82, 266, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 564, 206, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 170, 221, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 144, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 143, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 136, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 138, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 137, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 135, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 135, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 130, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 131, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 316, 132, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 133, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 140, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 140, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 139, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 140, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 127, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 235, 210, 0, 1171));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 259, 210, 0, 1171));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1165;
                case RoomExit.South: return 1177;
                case RoomExit.East:  return 1172;
                case RoomExit.West:  return 1170;
                default: return 0;
            }
        }
}
}
