using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1326 : Room
{
public Room1326()
: base(1326, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 318, 122, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 450, 135, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 132, 139, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 196, 138, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 364, 135, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 300, 144, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 241, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 634, 262, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 259, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 71, 324, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 613, 204, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 240, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 373, 173, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 195, 367, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 145, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 145, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 135, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 53, 211, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 138, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 138, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 138, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 136, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 210, 136, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 284, 142, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 143, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 316, 142, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 121, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 341, 133, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 134, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 134, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 332, 173, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 379, 257, 0, 1326));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 0, 238, 0, 1326));



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
