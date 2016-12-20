using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4002 : Room
{
public Room4002()
: base(4002, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 222, 195, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 438, 322, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 221, 197, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 451, 105, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 136, 105, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 521, 104, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 444, 322, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 592, 114, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 41, 117, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 119, 114, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 445, 204, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 264, 205, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 82, 206, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(32999, 602, 203, 0, 4002));
this.AddRoomDecoration(RoomDecoration.FromCode(32963, 604, 49, 0, 4002));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5077;
                case RoomExit.South: return 4017;
                case RoomExit.East:  return 4003;
                case RoomExit.West:  return 4001;
                default: return 0;
            }
        }
}
}
