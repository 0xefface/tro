using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10006 : Room
{
public Room10006()
: base(10006, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 568, 131, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 67, 132, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 586, 323, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 117, 108, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 610, 113, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 336, 110, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 576, 131, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 409, 113, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 628, 135, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 209, 112, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 101, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 91, 113, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 454, 113, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 519, 225, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 496, 241, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 576, 295, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 524, 230, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 408, 119, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 91, 123, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 268, 117, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 452, 122, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 288, 192, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 0, 137, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 266, 321, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 148, 326, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 45, 136, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 38, 327, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 254, 85, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 70, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 76, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 136, 76, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 185, 178, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 234, 194, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 71, 128, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 573, 261, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 348, 107, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 103, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 87, 128, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65531, 324, 0, 10006));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 5, 329, 0, 10006));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10014;
                case RoomExit.East:  return 10007;
                case RoomExit.West:  return 10005;
                default: return 0;
            }
        }
}
}
