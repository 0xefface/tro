using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1442 : Room
{
public Room1442()
: base(1442, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 236, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 256, 186, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 553, 277, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 236, 319, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 292, 237, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 544, 275, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 257, 189, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 62, 114, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 605, 123, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 515, 120, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 307, 234, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 531, 273, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 269, 239, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 330, 237, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 247, 233, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 242, 232, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 113, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 113, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 119, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 119, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 121, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 121, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 526, 251, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 619, 110, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 584, 111, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 622, 120, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 600, 123, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 571, 124, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 377, 266, 0, 1442));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 54, 314, 0, 1442));



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
