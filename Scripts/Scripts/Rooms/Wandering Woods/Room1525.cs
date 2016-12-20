using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1525 : Room
{
public Room1525()
: base(1525, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 441, 139, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 144, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 185, 136, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 557, 149, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 305, 139, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 144, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 510, 145, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 89, 136, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 33, 129, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 38, 257, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 329, 249, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 533, 294, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 269, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 370, 237, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 211, 219, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 206, 455, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 329, 259, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 55, 270, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 239, 228, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 359, 236, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 246, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 612, 211, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 391, 247, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 269, 214, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 560, 234, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 235, 222, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 217, 226, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 376, 251, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 130, 172, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 138, 121, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 130, 148, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 132, 122, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 134, 141, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 125, 174, 0, 1525));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 481, 224, 0, 1525));



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
