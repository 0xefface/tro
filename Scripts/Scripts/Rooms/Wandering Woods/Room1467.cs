using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1467 : Room
{
public Room1467()
: base(1467, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 576, 132, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 95, 125, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 285, 133, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 506, 139, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 614, 135, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 65, 135, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 482, 135, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 11, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 263, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 129, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 190, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 546, 134, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 204, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 255, 260, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 421, 210, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 579, 221, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 432, 223, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 37, 214, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 197, 241, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 437, 237, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 591, 220, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 419, 134, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 133, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 407, 125, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 483, 224, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 136, 0, 156, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 216, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 290, 251, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 133, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 133, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 137, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 137, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 137, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 134, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 134, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 134, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 133, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 136, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 138, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 137, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 330, 118, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 344, 131, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 313, 161, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(33015, 374, 228, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 568, 247, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 609, 288, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 351, 135, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 321, 173, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 339, 237, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 501, 227, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 460, 288, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 456, 283, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 341, 127, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 432, 280, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 545, 240, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 522, 291, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 65526, 206, 0, 1467));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65523, 206, 0, 1467));



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
