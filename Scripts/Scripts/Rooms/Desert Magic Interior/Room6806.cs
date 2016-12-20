using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6806 : Room
{
public Room6806()
: base(6806, "Desert Magic Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 318, 328, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 27, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 7, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 338, 49, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2111, 540, 96, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 329, 116, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 225, 49, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2163, 434, 49, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 32, 229, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2125, 323, 329, 65, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2153, 533, 207, 45, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(34898, 249, 199, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2102, 537, 206, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2124, 332, 117, 20, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2142, 65499, 230, 50, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(34914, 564, 97, 17, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2162, 617, 126, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2161, 28, 121, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2129, 353, 154, 65486, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2085, 231, 141, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2085, 423, 139, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 210, 139, 0, 6806));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 402, 137, 0, 6806));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
