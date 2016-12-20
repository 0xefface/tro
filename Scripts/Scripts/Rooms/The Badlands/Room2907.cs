using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2907 : Room
{
public Room2907()
: base(2907, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 100, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 369, 188, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 301, 185, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 256, 311, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 207, 118, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 168, 120, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 222, 125, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 45, 276, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 14, 279, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 296, 133, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 62, 325, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 500, 126, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 313, 314, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 63, 288, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 75, 316, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 329, 137, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 222, 134, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 274, 138, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 333, 139, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 315, 137, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 269, 132, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 510, 127, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 345, 146, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 563, 282, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 547, 252, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 434, 289, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 424, 256, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 417, 226, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 358, 206, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 248, 203, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 467, 206, 0, 2907));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 313, 230, 0, 2907));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2902;
                case RoomExit.South: return 2912;
                case RoomExit.East:  return 2908;
                case RoomExit.West:  return 2906;
                default: return 0;
            }
        }
}
}
