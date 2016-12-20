using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1329 : Room
{
public Room1329()
: base(1329, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 109, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 435, 125, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 132, 154, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 110, 142, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 592, 321, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 409, 252, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 251, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 240, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 105, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 122, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 30, 212, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 84, 238, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 94, 236, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 143, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 178, 259, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 144, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 138, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 145, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 140, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 135, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 135, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 276, 104, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 270, 131, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 269, 109, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 269, 159, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 275, 201, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 293, 201, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 288, 249, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 315, 238, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 429, 245, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 108, 231, 0, 1329));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 55, 205, 0, 1329));



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
