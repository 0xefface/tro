using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1402 : Room
{
public Room1402()
: base(1402, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 249, 185, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 384, 275, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 147, 184, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 439, 106, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 601, 138, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 183, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 238, 186, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 461, 275, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 413, 273, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 51, 119, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 456, 128, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 534, 135, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 125, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 135, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 135, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 135, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 135, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 139, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 139, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 139, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 124, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 119, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 119, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 119, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 647, 290, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 643, 295, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 578, 214, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 363, 273, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 607, 198, 0, 1402));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 505, 194, 0, 1402));



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
