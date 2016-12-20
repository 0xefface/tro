using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3157 : Room
{
public Room3157()
: base(3157, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 520, 113, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 73, 111, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 113, 244, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 165, 201, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 213, 197, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 202, 8, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 114, 245, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 192, 201, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 527, 122, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 432, 137, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 606, 133, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65479, 102, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 259, 103, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 460, 103, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 431, 102, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(32923, 618, 134, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 136, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 136, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 135, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 121, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 122, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 134, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 134, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 121, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 332, 105, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 325, 159, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 324, 134, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 326, 109, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 308, 204, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 294, 239, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 327, 228, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 335, 184, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 334, 155, 0, 3157));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 331, 132, 0, 3157));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3154;
                case RoomExit.South: return 3161;
                case RoomExit.East:  return 3157;
                case RoomExit.West:  return 3156;
                default: return 0;
            }
        }
}
}
