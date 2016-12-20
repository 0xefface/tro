using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4046 : Room
{
public Room4046()
: base(4046, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 385, 266, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 344, 271, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 448, 269, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 249, 185, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 384, 275, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 147, 184, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 439, 106, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 601, 138, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 183, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 238, 186, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 461, 275, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 413, 273, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 51, 119, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 456, 128, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 534, 135, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 125, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 191, 192, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 370, 265, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 135, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 135, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 135, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 135, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 139, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 139, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 139, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 124, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 119, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 119, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 119, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 149, 269, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 201, 268, 0, 4046));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 242, 256, 0, 4046));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4031;
                case RoomExit.South: return 1201;
                case RoomExit.East:  return 4047;
                case RoomExit.West:  return 4045;
                default: return 0;
            }
        }
}
}
