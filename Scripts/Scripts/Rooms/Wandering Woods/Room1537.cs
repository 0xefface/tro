using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1537 : Room
{
public Room1537()
: base(1537, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 109, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 397, 124, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 132, 154, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 29, 140, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 110, 142, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 393, 252, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 525, 219, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 240, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 286, 249, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 122, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 83, 235, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 94, 236, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 143, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 207, 265, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 144, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 138, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 145, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 140, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 135, 0, 1537));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 135, 0, 1537));



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
