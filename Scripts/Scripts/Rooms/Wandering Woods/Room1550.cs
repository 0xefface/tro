using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1550 : Room
{
public Room1550()
: base(1550, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 576, 132, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 95, 125, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 357, 130, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 506, 139, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 614, 135, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 65, 135, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 390, 131, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 11, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 285, 134, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 129, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 190, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 440, 137, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 546, 134, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 204, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 256, 258, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 468, 227, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 579, 221, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 400, 216, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 211, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 197, 241, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 548, 211, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 591, 220, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 449, 128, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 497, 134, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 483, 224, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 136, 0, 156, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 216, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 262, 237, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 137, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 137, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 137, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 134, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 272, 133, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 128, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 138, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 137, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 169, 254, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 379, 188, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32982, 305, 250, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 65, 253, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(219, 368, 162, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 347, 155, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 327, 146, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 340, 124, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 228, 259, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 17, 216, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 416, 225, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 564, 215, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 608, 220, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 320, 177, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 322, 155, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 361, 128, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 328, 162, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 377, 200, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 265, 286, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 277, 309, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 92, 283, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 88, 307, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 276, 231, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 418, 242, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 391, 234, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(139, 448, 227, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 535, 186, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 527, 201, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 516, 260, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 363, 121, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 353, 136, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 20, 296, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 362, 123, 0, 1550));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 655, 257, 0, 1550));



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
