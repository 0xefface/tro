using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1434 : Room
{
public Room1434()
: base(1434, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 110, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 197, 187, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 74, 135, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 33, 128, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 412, 268, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 415, 278, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 190, 190, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 312, 104, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 135, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 135, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 127, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 127, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 127, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 316, 105, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 309, 133, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 310, 112, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 305, 160, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 286, 211, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 274, 237, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 314, 162, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 304, 206, 0, 1434));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 295, 260, 0, 1434));



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
