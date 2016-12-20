using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1465 : Room
{
public Room1465()
: base(1465, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 125, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 536, 127, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 372, 128, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 138, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 572, 141, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 326, 138, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 138, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 605, 212, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 346, 307, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 419, 138, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 479, 222, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 450, 245, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 79, 215, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 454, 245, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 423, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 202, 221, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 139, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 473, 230, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 376, 233, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 349, 297, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 456, 169, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 286, 160, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 307, 153, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 539, 169, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 223, 251, 20, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 85, 271, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 110, 211, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 589, 208, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 390, 174, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 612, 215, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 513, 245, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 459, 248, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 357, 314, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 404, 260, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 440, 274, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 142, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 138, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 87, 247, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 93, 254, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 130, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 362, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 142, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 408, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 385, 140, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 142, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 139, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 57, 193, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 206, 220, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 211, 208, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 355, 248, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 237, 242, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 652, 203, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 271, 247, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 299, 248, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 474, 216, 0, 1465));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 491, 222, 0, 1465));



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
