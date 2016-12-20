using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5206 : Room
{
public Room5206()
: base(5206, "Murias Gatekeeper")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 364, 84, 60, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 548, 143, 20, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 567, 195, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 624, 200, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 714, 336, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 717, 176, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 287, 150, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 316, 190, 90, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 272, 183, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 354, 135, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 303, 189, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 573, 141, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 185, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 457, 186, 131, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 466, 41, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 619, 205, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 517, 197, 135, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 607, 22, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 417, 199, 154, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 230, 1, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 97, 37, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 64, 66, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 122, 1, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 39, 4, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 117, 3, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(2721, 435, 195, 0, 5206));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 449, 227, 0, 5206));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5201;
                case RoomExit.South: return 5211;
                case RoomExit.East:  return 5207;
                case RoomExit.West:  return 5205;
                default: return 0;
            }
        }
}
}
