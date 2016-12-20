using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1541 : Room
{
public Room1541()
: base(1541, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65509, 118, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 610, 121, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 397, 133, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 386, 265, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 211, 222, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 407, 258, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 621, 332, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 80, 229, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 230, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 119, 223, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 238, 112, 9, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 218, 226, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 197, 104, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(1061, 227, 104, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 422, 118, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(141, 270, 106, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(32908, 278, 104, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 323, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 146, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 139, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 503, 135, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 134, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 140, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 144, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 140, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 146, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 120, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(32901, 507, 243, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 531, 243, 0, 1541));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 461, 243, 0, 1541));



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
