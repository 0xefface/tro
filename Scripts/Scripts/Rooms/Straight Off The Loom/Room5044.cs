using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5044 : Room
{
public Room5044()
: base(5044, "Straight Off The Loom")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 143, 59, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 166, 67, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35379, 277, 68, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 281, 49, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 150, 167, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 38, 185, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 175, 185, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 27, 166, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2691, 441, 126, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 708, 331, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 709, 176, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 680, 15, 65437, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 535, 103, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 66, 211, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35484, 660, 112, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35484, 664, 115, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 664, 113, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35484, 165, 224, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 13, 211, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 65449, 215, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 38, 28, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35377, 102, 79, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 247, 187, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 263, 159, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35484, 129, 218, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35484, 219, 209, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 633, 314, 165, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 633, 275, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(35377, 439, 80, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2503, 377, 32, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 483, 58, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 12, 214, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 277, 210, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 93, 227, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(2535, 632, 410, 0, 5044));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 644, 319, 0, 5044));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5029;
                case RoomExit.South: return 5059;
                case RoomExit.East:  return 3012;
                case RoomExit.West:  return 5043;
                default: return 0;
            }
        }
}
}
