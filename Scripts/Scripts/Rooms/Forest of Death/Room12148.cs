using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12148 : Room
{
public Room12148()
: base(12148, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 109, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 661, 127, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 376, 131, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 132, 154, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 266, 137, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 492, 125, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 110, 142, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 393, 252, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 251, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 240, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 171, 122, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 83, 235, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 103, 246, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 617, 316, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 274, 334, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 56, 330, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 207, 265, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 144, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 139, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 138, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 145, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 140, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 125, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 125, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 136, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 136, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 143, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 591, 135, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 542, 99, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 539, 142, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 524, 169, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 504, 201, 0, 12148));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 487, 250, 0, 12148));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12143;
                case RoomExit.South: return 3151;
                case RoomExit.East:  return 12149;
                case RoomExit.West:  return 12147;
                default: return 0;
            }
        }
}
}
