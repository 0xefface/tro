using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12049 : Room
{
public Room12049()
: base(12049, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 23, 258, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 310, 260, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 545, 321, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 313, 274, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 55, 251, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 601, 208, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 538, 324, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 265, 256, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 218, 224, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 393, 234, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 357, 259, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 405, 266, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 306, 266, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 358, 280, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 448, 281, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 428, 239, 65516, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 307, 226, 65516, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 257, 249, 65516, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 231, 230, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 220, 220, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 55, 268, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 38, 250, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 9, 272, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 616, 216, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 594, 206, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 558, 332, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 509, 334, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 266, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 195, 227, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 195, 228, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 190, 222, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 443, 229, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 578, 203, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 74, 345, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 324, 338, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 452, 358, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 681, 351, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 200, 315, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 133, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 132, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 132, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 129, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 131, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 12049));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 12049));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12044;
                case RoomExit.South: return 3104;
                case RoomExit.East:  return 12145;
                case RoomExit.West:  return 12048;
                default: return 0;
            }
        }
}
}
