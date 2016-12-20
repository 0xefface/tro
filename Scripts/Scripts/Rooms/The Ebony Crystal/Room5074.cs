using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5074 : Room
{
public Room5074()
: base(5074, "The Ebony Crystal")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 318, 145, 70, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 427, 58, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 537, 143, 70, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 413, 152, 65466, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 444, 157, 65466, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 99, 212, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 146, 216, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 321, 212, 20, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 542, 217, 20, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 436, 172, 20, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 435, 77, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 326, 247, 150, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2611, 546, 184, 90, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 434, 160, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 582, 239, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 540, 204, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 70, 201, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 276, 231, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2543, 320, 199, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 596, 244, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 69, 41, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(35376, 186, 67, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2698, 138, 130, 20, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 223, 49, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 126, 48, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 167, 66, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 320, 242, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 532, 249, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 578, 250, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 463, 247, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 403, 242, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 648, 323, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(35302, 651, 162, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 724, 323, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 555, 258, 0, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 617, 147, 65466, 5074));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 625, 101, 65466, 5074));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5059;
                case RoomExit.South: return 5089;
                case RoomExit.East:  return 3030;
                case RoomExit.West:  return 5073;
                default: return 0;
            }
        }
}
}
