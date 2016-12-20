using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room16118 : Room
{
public Room16118()
: base(16118, "Wexfordshire Valley")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(62, 567, 301, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 215, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 363, 214, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 342, 222, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 132, 224, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 519, 104, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 229, 40, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 322, 104, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 214, 286, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 382, 210, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 323, 212, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 336, 188, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 387, 202, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 548, 302, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 378, 207, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 155, 238, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 65, 199, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 65406, 102, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 98, 102, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 65524, 124, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 65400, 111, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 65407, 117, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(173, 734, 102, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 639, 73, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 637, 75, 0, 16118));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 654, 71, 0, 16118));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1589;
                case RoomExit.South: return 16129;
                case RoomExit.East:  return 16119;
                case RoomExit.West:  return 1593;
                default: return 0;
            }
        }
}
}
