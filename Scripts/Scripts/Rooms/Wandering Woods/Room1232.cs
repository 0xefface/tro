using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1232 : Room
{
public Room1232()
: base(1232, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(49, 557, 249, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 104, 181, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 95, 193, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 64, 194, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 178, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 252, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 71, 175, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 88, 174, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 569, 326, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 185, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 94, 102, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(172, 83, 99, 65533, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(163, 555, 122, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 282, 215, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 84, 212, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 203, 215, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 359, 213, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 372, 198, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 109, 249, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 609, 346, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 56, 321, 0, 1232));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 265, 41, 0, 1232));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1226;
                case RoomExit.South: return 1238;
                case RoomExit.East:  return 1233;
                case RoomExit.West:  return 1231;
                default: return 0;
            }
        }
}
}
