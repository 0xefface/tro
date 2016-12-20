using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1169 : Room
{
public Room1169()
: base(1169, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 554, 128, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 362, 118, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 127, 127, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 114, 132, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 497, 135, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 176, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 51, 149, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 615, 144, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 433, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 235, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 556, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 347, 125, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 389, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 434, 240, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 218, 302, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 605, 196, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 337, 324, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 630, 240, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 180, 240, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 565, 194, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 20, 253, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 258, 221, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 171, 241, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 26, 262, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 599, 247, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 578, 193, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 276, 176, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 257, 222, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 56, 173, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 56, 197, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 613, 200, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 66, 148, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 148, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 105, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 132, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 130, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 123, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 122, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 130, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 131, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 134, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 134, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 521, 134, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 241, 114, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 313, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 370, 159, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 559, 199, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 419, 160, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(216, 297, 125, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 439, 196, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 355, 133, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 650, 200, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 553, 198, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 592, 197, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 505, 230, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 611, 235, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 510, 187, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 371, 183, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 421, 210, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 320, 160, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 267, 134, 0, 1169));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 252, 117, 0, 1169));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1163;
                case RoomExit.South: return 1175;
                case RoomExit.East:  return 1170;
                case RoomExit.West:  return 1168;
                default: return 0;
            }
        }
}
}
