using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5073 : Room
{
public Room5073()
: base(5073, "The Forge")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 180, 29, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 231, 41, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 321, 11, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 421, 34, 50, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 603, 134, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 649, 117, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2696, 409, 96, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2710, 392, 46, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(35370, 602, 57, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 439, 172, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 213, 194, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 231, 204, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 528, 195, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 186, 204, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 609, 199, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 494, 189, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 144, 187, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(35483, 212, 150, 65506, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 208, 175, 20, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 530, 143, 65506, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 580, 169, 20, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 479, 176, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 583, 182, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2541, 245, 156, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 498, 136, 0, 5073));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 285, 190, 0, 5073));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5058;
                case RoomExit.South: return 5088;
                case RoomExit.East:  return 5074;
                case RoomExit.West:  return 5072;
                default: return 0;
            }
        }
}
}
