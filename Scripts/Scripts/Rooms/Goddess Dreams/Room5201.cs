using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5201 : Room
{
public Room5201()
: base(5201, "Goddess Dreams")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 181, 15, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 167, 20, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 410, 149, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 452, 140, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 626, 212, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2607, 65483, 184, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(35375, 378, 187, 12, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(32788, 65532, 215, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 438, 233, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 153, 166, 112, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 251, 178, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 251, 172, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 631, 184, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 433, 45, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 381, 23, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2621, 502, 158, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 65363, 166, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2698, 174, 94, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 400, 235, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 472, 234, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 378, 222, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 555, 135, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 392, 228, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 488, 220, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 666, 214, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 65519, 233, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 456, 73, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 615, 126, 65466, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 499, 104, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 482, 132, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 464, 55, 0, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 586, 90, 65476, 5201));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 573, 149, 0, 5201));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 16131;
                case RoomExit.South: return 5206;
                case RoomExit.East:  return 5202;
                case RoomExit.West:  return 5200;
                default: return 0;
            }
        }
}
}
