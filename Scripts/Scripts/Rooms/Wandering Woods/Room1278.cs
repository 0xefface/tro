using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1278 : Room
{
public Room1278()
: base(1278, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 576, 132, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 95, 125, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 362, 131, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 506, 139, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 614, 135, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 65, 135, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 482, 135, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 11, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 284, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 129, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 190, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 546, 134, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 204, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 255, 260, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 484, 212, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 579, 221, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 437, 211, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 211, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 197, 241, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 428, 274, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 591, 220, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 405, 127, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 133, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 466, 209, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 136, 0, 156, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 216, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 290, 251, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 133, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 133, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 137, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 137, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 137, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 134, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 134, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 134, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 135, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 125, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 136, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 138, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 137, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 329, 123, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 345, 142, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 441, 253, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 507, 220, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 388, 215, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 323, 216, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 346, 278, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 339, 244, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 441, 226, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 470, 232, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 373, 317, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 373, 140, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 330, 133, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 332, 200, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 398, 277, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(32896, 362, 275, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 318, 120, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 347, 150, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 412, 196, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 449, 334, 0, 1278));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 312, 129, 0, 1278));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
