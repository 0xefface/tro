using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5907 : Room
{
public Room5907()
: base(5907, "Asgard")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 396, 124, 70, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 348, 153, 90, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 167, 227, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 131, 224, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 260, 222, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65534, 46, 65456, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 0, 136, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 583, 122, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 592, 103, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 553, 101, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 201, 223, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 223, 224, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 65534, 5, 65456, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 158, 223, 65, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2582, 261, 185, 15, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 630, 327, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 219, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 272, 268, 200, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 290, 61, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 196, 215, 149, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 217, 228, 160, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2605, 164, 227, 160, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 147, 60, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 142, 222, 36, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 67, 14, 65456, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 98, 40, 65456, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 106, 218, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 484, 4, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 546, 103, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 563, 39, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 542, 61, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 53, 124, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(2724, 297, 220, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 265, 235, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 369, 226, 0, 5907));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 180, 222, 0, 5907));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5903;
                case RoomExit.South: return 5910;
                case RoomExit.East:  return 5908;
                case RoomExit.West:  return 5906;
                default: return 0;
            }
        }
}
}
