using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1142 : Room
{
public Room1142()
: base(1142, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 298, 103, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 483, 114, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 184, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 17, 325, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 91, 261, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 63, 286, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 68, 283, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65499, 291, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 113, 288, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 420, 52, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 536, 108, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 68, 326, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 91, 270, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 51, 104, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 15, 103, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 42, 310, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 483, 119, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 125, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 126, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 184, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 125, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 125, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 124, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 122, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 117, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 120, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 121, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 328, 105, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 324, 121, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 323, 136, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 289, 144, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 288, 151, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 193, 166, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 56, 167, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 201, 161, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 72, 161, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 225, 190, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 141, 190, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 273, 161, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 199, 162, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 128, 162, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 290, 160, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 269, 188, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 135, 227, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 648, 229, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 656, 230, 0, 1142));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 636, 233, 0, 1142));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1133;
                case RoomExit.South: return 1252;
                case RoomExit.East:  return 1143;
                case RoomExit.West:  return 1141;
                default: return 0;
            }
        }
}
}
