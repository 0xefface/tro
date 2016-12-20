using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1355 : Room
{
public Room1355()
: base(1355, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 353, 128, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 508, 130, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 105, 134, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 522, 139, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 220, 136, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 111, 138, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 459, 138, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 571, 134, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 45, 143, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 286, 132, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 131, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 334, 133, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 597, 139, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 600, 209, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 463, 248, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 344, 233, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 463, 250, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 186, 224, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 39, 258, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 119, 221, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 193, 222, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 204, 221, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 355, 220, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 359, 236, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 599, 210, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 225, 211, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 53, 243, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 599, 215, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 170, 221, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 144, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 143, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 136, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 138, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 137, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 135, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 135, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 130, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 131, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 316, 132, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 133, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 140, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 140, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 139, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 140, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 127, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 235, 210, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 212, 211, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32987, 347, 183, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 273, 188, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 453, 177, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 577, 181, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 258, 254, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 109, 224, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 128, 210, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 154, 241, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 358, 240, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 358, 211, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 416, 209, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 523, 208, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 632, 215, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 212, 328, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 287, 327, 0, 1355));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 653, 319, 0, 1355));



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
