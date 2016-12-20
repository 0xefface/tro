using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1685 : Room
{
public Room1685()
: base(1685, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 167, 126, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 127, 136, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 178, 144, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 383, 144, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 70, 139, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 347, 138, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 109, 139, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 578, 141, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 276, 142, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 19, 133, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 354, 198, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 529, 313, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 39, 258, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 382, 320, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 333, 248, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 359, 125, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 233, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 274, 229, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 293, 197, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 347, 227, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 36, 259, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 351, 259, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 470, 254, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(32971, 294, 213, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 368, 195, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 277, 223, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 367, 199, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 224, 230, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 400, 266, 0, 1685));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 356, 214, 0, 1685));



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
