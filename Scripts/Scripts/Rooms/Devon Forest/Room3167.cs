using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3167 : Room
{
public Room3167()
: base(3167, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 110, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 197, 187, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 74, 135, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 33, 128, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 412, 268, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 415, 278, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 11, 202, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 312, 104, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 135, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 135, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 127, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 127, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 127, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 54, 260, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 65509, 165, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 271, 0, 3167));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 4, 273, 0, 3167));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3161;
                case RoomExit.South: return 3175;
                case RoomExit.East:  return 3168;
                case RoomExit.West:  return 3166;
                default: return 0;
            }
        }
}
}
