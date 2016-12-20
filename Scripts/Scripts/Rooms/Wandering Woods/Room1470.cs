using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1470 : Room
{
public Room1470()
: base(1470, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 76, 132, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 314, 123, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 569, 134, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 522, 140, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 147, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 179, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 242, 140, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 322, 142, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 294, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 147, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 114, 133, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 48, 132, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 38, 210, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 477, 292, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 597, 256, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 412, 270, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 89, 198, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 17, 329, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 593, 258, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 201, 209, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 538, 352, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 130, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 51, 208, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 60, 197, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 255, 203, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 490, 303, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 232, 208, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 33, 222, 65516, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 199, 245, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 315, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 203, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 187, 204, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 139, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 140, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 140, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 138, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 145, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 145, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 145, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 147, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 147, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 147, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 141, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 143, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 197, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 39, 197, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 165, 197, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 311, 191, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 427, 108, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 439, 120, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 347, 171, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 389, 146, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(32984, 370, 156, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 121, 236, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 244, 234, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 335, 209, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 429, 121, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 403, 156, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 385, 169, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 343, 163, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 446, 145, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 28, 232, 0, 1470));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 417, 114, 0, 1470));



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
