using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1047 : Room
{
public Room1047()
: base(1047, "West Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(174, 247, 102, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 376, 189, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 369, 187, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 376, 194, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 394, 195, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 77, 242, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 120, 200, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 234, 308, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 531, 384, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 181, 253, 65535, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 225, 129, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 65530, 260, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 307, 55, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(33003, 476, 156, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 412, 147, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 233, 109, 20, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 761, 104, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32942, 280, 103, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(174, 65375, 103, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 297, 100, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 365, 105, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 596, 112, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32931, 97, 123, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32966, 697, 59, 20, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(195, 621, 47, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 663, 256, 65533, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 76, 243, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 256, 143, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 319, 147, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 573, 172, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 229, 110, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 86, 257, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 111, 296, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 104, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 105, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 111, 275, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32980, 475, 254, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 573, 298, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 574, 277, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 113, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 113, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 113, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 633, 113, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 408, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 106, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 105, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 308, 105, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 284, 105, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 233, 138, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 214, 168, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 323, 249, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 311, 244, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 296, 209, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 275, 228, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 246, 212, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 257, 288, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 29, 305, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 391, 306, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 386, 282, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 256, 304, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 618, 315, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 108, 301, 0, 1047));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 566, 290, 0, 1047));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1041;
                case RoomExit.South: return 1155;
                case RoomExit.East:  return 4000;
                case RoomExit.West:  return 1046;
                default: return 0;
            }
        }
}
}
