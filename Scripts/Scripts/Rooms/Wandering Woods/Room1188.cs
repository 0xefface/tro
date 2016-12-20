using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1188 : Room
{
public Room1188()
: base(1188, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 89, 124, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 528, 123, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 302, 133, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 439, 138, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 619, 145, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 164, 138, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 565, 134, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 361, 145, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 278, 135, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 374, 134, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 508, 144, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 135, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 491, 238, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 25, 258, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 419, 327, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 134, 244, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 50, 249, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 606, 199, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 417, 247, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 500, 256, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 144, 244, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 482, 253, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 133, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 138, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 133, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 279, 144, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 138, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 379, 192, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 530, 264, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 267, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 247, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 399, 195, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 380, 198, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 507, 248, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 617, 218, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 605, 207, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 144, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 131, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 132, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 134, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 143, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 143, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 134, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 144, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 288, 227, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 255, 227, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 270, 226, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 292, 275, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 74, 202, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 217, 202, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 384, 199, 0, 1188));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 560, 199, 0, 1188));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1182;
                case RoomExit.South: return 1194;
                case RoomExit.East:  return 1189;
                case RoomExit.West:  return 1187;
                default: return 0;
            }
        }
}
}
