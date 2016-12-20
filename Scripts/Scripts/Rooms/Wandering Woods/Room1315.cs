using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1315 : Room
{
public Room1315()
: base(1315, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 441, 139, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 144, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 175, 140, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 557, 149, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 305, 139, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 144, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 510, 145, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 100, 136, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 33, 129, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 38, 257, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 329, 249, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 269, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 370, 237, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 211, 219, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 269, 214, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 329, 259, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 55, 270, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 239, 228, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 359, 236, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 246, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 612, 211, 0, 1315));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 391, 247, 0, 1315));



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
