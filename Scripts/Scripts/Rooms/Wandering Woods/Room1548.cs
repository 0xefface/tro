using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1548 : Room
{
public Room1548()
: base(1548, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 147, 139, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 446, 243, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 261, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 259, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 47, 245, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 655, 293, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 618, 285, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 547, 166, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 613, 322, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 549, 183, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 634, 279, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 505, 158, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 543, 200, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 125, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 199, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 199, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 137, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 131, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 138, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 138, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 129, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 143, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 143, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 141, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 141, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 157, 0, 1548));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 157, 0, 1548));



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
