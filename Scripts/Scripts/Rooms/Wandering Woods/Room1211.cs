using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1211 : Room
{
public Room1211()
: base(1211, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(50, 428, 257, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 319, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 328, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 258, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 388, 256, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 578, 144, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 590, 146, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 92, 113, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 591, 129, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 440, 111, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 224, 105, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 127, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 128, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 128, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 128, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 635, 128, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 117, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 414, 252, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 91, 317, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 367, 253, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 580, 141, 0, 1211));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 562, 144, 0, 1211));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1205;
                case RoomExit.South: return 1217;
                case RoomExit.East:  return 4107;
                case RoomExit.West:  return 1210;
                default: return 0;
            }
        }
}
}
