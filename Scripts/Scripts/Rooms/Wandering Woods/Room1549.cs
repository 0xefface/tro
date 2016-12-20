using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1549 : Room
{
public Room1549()
: base(1549, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 21, 123, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 496, 126, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 295, 130, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 466, 140, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 524, 149, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 576, 139, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 290, 133, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 363, 137, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 626, 149, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 308, 315, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 380, 315, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 281, 263, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 441, 221, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 151, 246, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 253, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 234, 263, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 148, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 298, 252, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 130, 250, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 238, 265, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 350, 259, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 267, 315, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 538, 321, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 139, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 140, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 137, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 133, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 133, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 137, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 136, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 136, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 140, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 139, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 139, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 151, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 151, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 151, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(132, 462, 225, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 176, 260, 0, 1549));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 325, 311, 0, 1549));



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
