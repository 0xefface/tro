using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1116 : Room
{
public Room1116()
: base(1116, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(45, 486, 248, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 492, 249, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 198, 118, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 127, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 115, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 335, 103, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 26, 126, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 117, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 117, 0, 1116));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 117, 0, 1116));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1110;
                case RoomExit.South: return 1125;
                case RoomExit.East:  return 1117;
                case RoomExit.West:  return 1115;
                default: return 0;
            }
        }
}
}
