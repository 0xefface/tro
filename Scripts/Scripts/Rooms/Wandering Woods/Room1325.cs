using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1325 : Room
{
public Room1325()
: base(1325, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 569, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 17, 153, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 371, 143, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 61, 146, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 288, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 269, 325, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 334, 320, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 422, 216, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 313, 248, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 187, 256, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 12, 223, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 12, 191, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 179, 328, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 243, 260, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 138, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 138, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 613, 316, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 135, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 138, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 135, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 19, 265, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 41, 289, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 26, 200, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 0, 300, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 323, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 136, 328, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 48, 201, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 208, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 29, 221, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 563, 333, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 304, 261, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 225, 257, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 208, 251, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 270, 197, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 199, 191, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 445, 228, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 191, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65, 200, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 616, 338, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 503, 133, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 46, 145, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 144, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 270, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 142, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 139, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 649, 242, 0, 1325));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 644, 246, 0, 1325));



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
