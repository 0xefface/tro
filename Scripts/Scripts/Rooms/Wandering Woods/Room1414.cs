using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1414 : Room
{
public Room1414()
: base(1414, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 485, 127, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 34, 119, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 408, 222, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 187, 133, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 324, 136, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 145, 132, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 341, 137, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 96, 137, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 377, 144, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 52, 134, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 552, 139, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 444, 222, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 132, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 136, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 138, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 131, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 131, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 391, 137, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 136, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 163, 104, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 138, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 310, 134, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 333, 135, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 354, 136, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 375, 136, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 620, 262, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 623, 260, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 447, 222, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 64, 350, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 29, 307, 0, 1414));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 34, 315, 0, 1414));



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
