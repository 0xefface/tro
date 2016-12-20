using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1111 : Room
{
public Room1111()
: base(1111, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 372, 104, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 110, 122, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 505, 395, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 365, 41, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 1111));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 124, 0, 1111));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1106;
                case RoomExit.South: return 1117;
                case RoomExit.East:  return 1162;
                case RoomExit.West:  return 1110;
                default: return 0;
            }
        }
}
}
