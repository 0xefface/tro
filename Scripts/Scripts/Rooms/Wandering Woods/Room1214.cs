using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1214 : Room
{
public Room1214()
: base(1214, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 89, 112, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 531, 112, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 126, 115, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 363, 296, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 172, 182, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 188, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 383, 286, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 169, 185, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 257, 38, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 248, 356, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 174, 189, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 490, 176, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 435, 292, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 484, 171, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 315, 297, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 477, 171, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 521, 181, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 440, 287, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 282, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 288, 103, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 282, 132, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 282, 105, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 319, 157, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 333, 156, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 409, 174, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 566, 181, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 456, 190, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 407, 199, 0, 1214));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 533, 207, 0, 1214));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1208;
                case RoomExit.South: return 1220;
                case RoomExit.East:  return 1215;
                case RoomExit.West:  return 1213;
                default: return 0;
            }
        }
}
}
