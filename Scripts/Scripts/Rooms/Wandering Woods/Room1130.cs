using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1130 : Room
{
public Room1130()
: base(1130, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 603, 323, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 557, 249, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 97, 194, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 295, 102, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 90, 102, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 4, 115, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 478, 116, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 187, 46, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 64, 194, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 178, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 532, 253, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 71, 175, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 88, 174, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 569, 326, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 185, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 301, 102, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 296, 124, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 292, 144, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 548, 207, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 589, 244, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 496, 203, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 369, 179, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 362, 185, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 511, 247, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 453, 247, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 419, 239, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 496, 204, 0, 1130));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 424, 203, 0, 1130));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1123;
                case RoomExit.South: return 1138;
                case RoomExit.East:  return 1131;
                case RoomExit.West:  return 1129;
                default: return 0;
            }
        }
}
}
