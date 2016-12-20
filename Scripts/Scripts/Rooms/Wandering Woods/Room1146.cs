using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1146 : Room
{
public Room1146()
: base(1146, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 202, 105, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 6, 103, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 362, 113, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 180, 173, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 564, 245, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 578, 244, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 166, 170, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 176, 166, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 585, 116, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 50, 112, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 627, 129, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 626, 206, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 620, 313, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 585, 241, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 611, 206, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 620, 297, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 130, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 130, 0, 1146));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 578, 246, 0, 1146));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1137;
                case RoomExit.South: return 1256;
                case RoomExit.East:  return 1147;
                case RoomExit.West:  return 1145;
                default: return 0;
            }
        }
}
}
