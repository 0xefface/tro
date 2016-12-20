using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1120 : Room
{
public Room1120()
: base(1120, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 514, 109, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 237, 227, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 134, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 134, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 65520, 196, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 134, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 107, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 300, 37, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 54, 134, 0, 1120));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 242, 231, 0, 1120));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1113;
                case RoomExit.South: return 1127;
                case RoomExit.East:  return 1121;
                case RoomExit.West:  return 1119;
                default: return 0;
            }
        }
}
}
