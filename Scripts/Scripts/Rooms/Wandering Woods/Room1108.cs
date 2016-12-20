using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1108 : Room
{
public Room1108()
: base(1108, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 333, 103, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 561, 176, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 557, 194, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 321, 197, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 329, 196, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 268, 355, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 39, 312, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 228, 288, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 129, 304, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 133, 286, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 178, 213, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 198, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 140, 297, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 95, 292, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 325, 211, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 197, 305, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 228, 294, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 296, 27, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 433, 169, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 447, 177, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 378, 205, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 394, 238, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 364, 194, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 372, 247, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 580, 165, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 493, 161, 0, 1108));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 590, 158, 0, 1108));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22041;
                case RoomExit.South: return 1114;
                case RoomExit.East:  return 1109;
                case RoomExit.West:  return 1107;
                default: return 0;
            }
        }
}
}
