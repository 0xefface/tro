using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1133 : Room
{
public Room1133()
: base(1133, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 178, 108, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 574, 309, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 564, 318, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 139, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 104, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 328, 1, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 255, 106, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 37, 121, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 84, 110, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 19, 138, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 339, 106, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 332, 135, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 335, 115, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 337, 145, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 324, 187, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 294, 236, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 331, 235, 0, 1133));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 336, 182, 0, 1133));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1125;
                case RoomExit.South: return 1142;
                case RoomExit.East:  return 1134;
                case RoomExit.West:  return 1132;
                default: return 0;
            }
        }
}
}
