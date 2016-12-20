using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4031 : Room
{
public Room4031()
: base(4031, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 501, 112, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 70, 110, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 47, 204, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 42, 206, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 486, 280, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 122, 118, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 116, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 59, 205, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 273, 116, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 517, 283, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 496, 280, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 118, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 118, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 118, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 118, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 117, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 4031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 119, 0, 4031));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4016;
                case RoomExit.South: return 4046;
                case RoomExit.East:  return 4032;
                case RoomExit.West:  return 4030;
                default: return 0;
            }
        }
}
}
