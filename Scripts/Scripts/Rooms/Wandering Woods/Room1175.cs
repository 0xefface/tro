using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1175 : Room
{
public Room1175()
: base(1175, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 464, 131, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 91, 126, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 309, 131, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 544, 150, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 55, 134, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 299, 136, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 635, 144, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 374, 140, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 472, 143, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 137, 136, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 553, 142, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 190, 135, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 430, 135, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 22, 209, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 575, 254, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 359, 257, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 575, 252, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 304, 247, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 128, 310, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 141, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 130, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 130, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 134, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 22, 137, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 242, 142, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 362, 132, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 55, 329, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 233, 240, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 131, 320, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65473, 126, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 597, 246, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 434, 305, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 134, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 137, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 137, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 51, 129, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 129, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 131, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 141, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 231, 142, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 139, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 139, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 149, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 149, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 149, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 149, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 142, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 141, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 141, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 133, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 139, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 140, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65524, 262, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 65520, 241, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 65494, 199, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 18, 239, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 428, 221, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 469, 247, 0, 1175));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 397, 245, 0, 1175));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1169;
                case RoomExit.South: return 1181;
                case RoomExit.East:  return 1176;
                case RoomExit.West:  return 1174;
                default: return 0;
            }
        }
}
}
