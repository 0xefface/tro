using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1503 : Room
{
public Room1503()
: base(1503, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 109, 120, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 120, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 324, 122, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 564, 169, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 427, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 97, 129, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 572, 149, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 148, 130, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 214, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 126, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 222, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 620, 127, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 126, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 49, 280, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 526, 281, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 68, 281, 9, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 206, 210, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 142, 221, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 132, 212, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 83, 324, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 306, 0, 20, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 556, 269, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(218, 275, 35, 2, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 237, 298, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 435, 130, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 319, 119, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 427, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 261, 127, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 7, 81, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 231, 321, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 325, 316, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 340, 294, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 101, 314, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 358, 244, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 278, 198, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 120, 216, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 173, 134, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 119, 249, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 266, 192, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 303, 159, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 547, 282, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 266, 305, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 220, 320, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 232, 298, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 508, 338, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 339, 281, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 140, 237, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 191, 225, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 12, 217, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 104, 325, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 75, 316, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 61, 326, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 579, 327, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 110, 315, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 31, 202, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 367, 290, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 317, 152, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 374, 122, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 572, 319, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 304, 304, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 40, 254, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 528, 335, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 126, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 96, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 121, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 178, 129, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 127, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 127, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 240, 128, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 127, 0, 1503));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 126, 0, 1503));



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
