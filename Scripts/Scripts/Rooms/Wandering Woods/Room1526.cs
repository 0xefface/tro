using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1526 : Room
{
public Room1526()
: base(1526, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65511, 119, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 474, 136, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 331, 127, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 497, 139, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 168, 142, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 242, 142, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 361, 139, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 421, 142, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 563, 141, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 103, 130, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 38, 128, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 310, 248, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 505, 319, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 378, 254, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 62, 211, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 185, 238, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 143, 238, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 422, 219, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 70, 191, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 585, 255, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 226, 117, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 453, 124, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 469, 148, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 283, 146, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 225, 150, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 77, 144, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 24, 210, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 129, 229, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 206, 253, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 326, 258, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 427, 259, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 48, 303, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 253, 193, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 144, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 143, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 218, 149, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 236, 150, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 263, 145, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 145, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 336, 139, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 140, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 383, 139, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 147, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 147, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 140, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 142, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 65525, 226, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 650, 211, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 467, 230, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 446, 222, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 327, 256, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 171, 233, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 190, 227, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 422, 312, 0, 1526));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 577, 250, 0, 1526));



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
