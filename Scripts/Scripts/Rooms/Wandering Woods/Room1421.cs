using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1421 : Room
{
public Room1421()
: base(1421, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 133, 185, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 592, 299, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 158, 203, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 153, 205, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 585, 296, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 121, 187, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 114, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 168, 113, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 417, 113, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 178, 204, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 344, 184, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 473, 182, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 587, 182, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 234, 187, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 222, 250, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 531, 214, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 298, 217, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 415, 175, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 407, 168, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 415, 208, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 401, 207, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 242, 262, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 196, 264, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 256, 323, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 151, 329, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 204, 325, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 28, 322, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 16, 318, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 624, 215, 0, 1421));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 650, 318, 0, 1421));



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
