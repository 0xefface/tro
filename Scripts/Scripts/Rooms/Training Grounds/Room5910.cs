using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5910 : Room
{
public Room5910()
: base(5910, "Training Grounds")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(1588, 319, 211, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1586, 201, 185, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 334, 79, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 20, 291, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 154, 113, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 9, 329, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 416, 118, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 233, 117, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 337, 116, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 42, 335, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 229, 145, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 351, 146, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 464, 140, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 211, 131, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 493, 165, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 52, 61, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 156, 160, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 281, 166, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 413, 177, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 237, 190, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 618, 320, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 350, 196, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(34354, 534, 156, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(1588, 444, 195, 65526, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 98, 43, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 90, 279, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 531, 283, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 548, 35, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 74, 41, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 573, 40, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 675, 243, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 622, 268, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 1, 263, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 24, 255, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 658, 75, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65500, 94, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 663, 208, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 102, 63, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 507, 63, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 571, 87, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 564, 255, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 505, 285, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 592, 70, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 15, 99, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 35, 97, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 143, 288, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 43, 343, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 577, 343, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 50, 34, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 578, 36, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 84, 265, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 12, 72, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 131, 27, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 475, 26, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 6, 231, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 599, 70, 0, 5910));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 39, 100, 0, 5910));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5907;
                case RoomExit.South: return 1280;
                case RoomExit.East:  return 5911;
                case RoomExit.West:  return 5909;
                default: return 0;
            }
        }
}
}
