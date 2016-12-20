using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1533 : Room
{
public Room1533()
: base(1533, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 324, 122, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 453, 139, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 291, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 152, 261, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 95, 183, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 146, 260, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 597, 254, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 139, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 146, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 146, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 46, 215, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 171, 250, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 241, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 369, 258, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 449, 230, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 606, 320, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 615, 339, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 464, 341, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 143, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 143, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 181, 140, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 139, 0, 1533));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 121, 140, 0, 1533));



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
