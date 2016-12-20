using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1132 : Room
{
public Room1132()
: base(1132, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65476, 103, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 490, 112, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 185, 112, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 462, 193, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 342, 201, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 348, 208, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 371, 224, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 462, 201, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 461, 219, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 462, 191, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 359, 199, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 419, 228, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 406, 210, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 107, 266, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 76, 272, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 73, 285, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 112, 285, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 11, 263, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 469, 192, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 478, 105, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 76, 284, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 224, 113, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 201, 117, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 239, 116, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 83, 271, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 226, 117, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 197, 118, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 221, 119, 0, 1132));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 244, 118, 0, 1132));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 22092;
                case RoomExit.South: return 1141;
                case RoomExit.East:  return 1133;
                case RoomExit.West:  return 22099;
                default: return 0;
            }
        }
}
}
