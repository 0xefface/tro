using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3251 : Room
{
public Room3251()
: base(3251, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 514, 109, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 237, 227, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 134, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 134, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 65520, 196, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 134, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 107, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 300, 37, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 54, 134, 0, 3251));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 242, 231, 0, 3251));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3195;
                case RoomExit.South: return 3257;
                case RoomExit.East:  return 3252;
                case RoomExit.West:  return 3150;
                default: return 0;
            }
        }
}
}
