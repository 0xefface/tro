using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2922 : Room
{
public Room2922()
: base(2922, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 578, 289, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 75, 316, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 43, 274, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(32891, 538, 230, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 235, 285, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(58103, 264, 0, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 653, 252, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 131, 317, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 67, 288, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 276, 292, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 119, 277, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 32, 238, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 73, 255, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 11, 180, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 17, 317, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 265, 307, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 186, 285, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 74, 255, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 271, 314, 0, 2922));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 380, 300, 0, 2922));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2917;
                case RoomExit.South: return 7003;
                case RoomExit.East:  return 2923;
                case RoomExit.West:  return 2921;
                default: return 0;
            }
        }
}
}
