using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1529 : Room
{
public Room1529()
: base(1529, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 125, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 354, 138, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 449, 147, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 93, 145, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 249, 137, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 385, 142, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 528, 145, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 432, 258, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 600, 208, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 429, 259, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 247, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 482, 238, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 30, 257, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 453, 255, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 329, 251, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 324, 143, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 562, 140, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 396, 191, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 41, 142, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 148, 143, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 272, 211, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 49, 270, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(385, 142, 0, 156, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 329, 256, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 452, 270, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 476, 243, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 432, 253, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 476, 234, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 617, 218, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 145, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 145, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 113, 143, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 143, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 143, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 141, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 136, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 272, 136, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 141, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 467, 147, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 144, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 151, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 220, 216, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 1, 325, 0, 1529));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 65525, 328, 0, 1529));



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
