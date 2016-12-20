using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1136 : Room
{
public Room1136()
: base(1136, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(50, 420, 236, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 319, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 328, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 417, 241, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 235, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 578, 144, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 581, 149, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 92, 113, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 591, 129, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 440, 111, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 224, 105, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 127, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 128, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 128, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 128, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 635, 128, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 117, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 59, 273, 0, 1136));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 11, 317, 0, 1136));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1128;
                case RoomExit.South: return 1145;
                case RoomExit.East:  return 1137;
                case RoomExit.West:  return 1135;
                default: return 0;
            }
        }
}
}
