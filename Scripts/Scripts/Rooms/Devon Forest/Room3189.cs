using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3189 : Room
{
public Room3189()
: base(3189, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 284, 103, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 410, 103, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 91, 102, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 448, 212, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 431, 215, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 336, 269, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 233, 179, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 323, 260, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 423, 207, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 188, 257, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 358, 264, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 240, 181, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 407, 205, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 50, 128, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 98, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 69, 138, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 379, 113, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 490, 113, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 556, 137, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 621, 147, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 166, 258, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 226, 182, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 475, 211, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 584, 149, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 608, 149, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 630, 150, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 586, 144, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 612, 143, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 632, 143, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 113, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 136, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 127, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 283, 126, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 313, 105, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 332, 182, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(33015, 353, 218, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 554, 237, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 313, 109, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 297, 132, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 310, 192, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 335, 229, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 447, 218, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 440, 270, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 490, 269, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 548, 282, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 633, 282, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 615, 268, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 406, 266, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 524, 289, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 572, 290, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 624, 273, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 530, 323, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 586, 323, 0, 3189));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 315, 118, 0, 3189));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3182;
                case RoomExit.South: return 3195;
                case RoomExit.East:  return 3190;
                case RoomExit.West:  return 3188;
                default: return 0;
            }
        }
}
}
