using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12147 : Room
{
public Room12147()
: base(12147, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 318, 122, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 450, 135, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 132, 139, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 196, 138, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 364, 135, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 300, 144, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 241, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 447, 243, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 259, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 93, 214, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 655, 293, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 611, 328, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 380, 338, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 124, 355, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 53, 211, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 138, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 138, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 138, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 136, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 210, 136, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 284, 142, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 143, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 316, 142, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 121, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 341, 133, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 134, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 134, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 135, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 145, 0, 12147));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 145, 0, 12147));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12142;
                case RoomExit.South: return 3150;
                case RoomExit.East:  return 12148;
                case RoomExit.West:  return 12146;
                default: return 0;
            }
        }
}
}
