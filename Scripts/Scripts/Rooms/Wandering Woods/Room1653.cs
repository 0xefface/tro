using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1653 : Room
{
public Room1653()
: base(1653, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 282, 109, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 115, 346, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 87, 133, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 183, 318, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 86, 134, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 487, 103, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 4, 22, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 297, 104, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 125, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 122, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 122, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 122, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 124, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 124, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(954, 7, 103, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(939, 4, 193, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(938, 77, 123, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 201, 316, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 574, 96, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 523, 264, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 403, 290, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 545, 216, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 71, 107, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 10, 127, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 127, 106, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 646, 245, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 624, 259, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 1, 218, 0, 1653));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 55, 172, 0, 1653));



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
