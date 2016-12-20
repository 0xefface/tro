using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1598 : Room
{
public Room1598()
: base(1598, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 23, 258, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 304, 267, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 545, 321, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 313, 274, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 55, 251, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 598, 197, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 538, 324, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 265, 256, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 218, 224, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 355, 251, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 405, 266, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 266, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 195, 227, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 190, 222, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 443, 229, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 579, 193, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 131, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 129, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 175, 320, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 133, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 132, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 132, 0, 1598));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 1598));



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
