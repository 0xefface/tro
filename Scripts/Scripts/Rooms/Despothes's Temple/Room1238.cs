using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1238 : Room
{
public Room1238()
: base(1238, "Despothes's Temple")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 275, 230, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 245, 229, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 300, 200, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 578, 79, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 43, 108, 65376, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 542, 199, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 324, 212, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35107, 95, 128, 1, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35107, 0, 143, 1, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 171, 127, 65389, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 105, 120, 65389, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 41, 140, 65418, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 15, 366, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 172, 128, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 13, 231, 80, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 556, 146, 5, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 173, 123, 65376, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 107, 116, 65376, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35123, 133, 137, 45, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35123, 65527, 159, 45, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35123, 63, 148, 45, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35124, 63, 144, 50, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35124, 65527, 155, 50, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(35124, 133, 133, 50, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2384, 154, 129, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2387, 96, 218, 153, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2384, 32, 217, 143, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2387, 103, 237, 100, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2384, 40, 237, 91, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2384, 153, 199, 143, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 158, 113, 65395, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 283, 190, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 363, 248, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 440, 203, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 521, 253, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 613, 201, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 190, 112, 65386, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 228, 90, 65517, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 629, 106, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 580, 120, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 498, 65, 7, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(164, 296, 64, 9, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(155, 639, 128, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(155, 233, 101, 65516, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 115, 95, 65372, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2712, 80, 51, 65354, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 72, 229, 65471, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 101, 228, 65457, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 32, 189, 65446, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 144, 226, 65475, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 7, 33, 11, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 400, 149, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 224, 108, 65432, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 381, 203, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 358, 250, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 512, 226, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 340, 56, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 577, 294, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 594, 201, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 310, 290, 65503, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 470, 203, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 601, 232, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 350, 237, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 491, 237, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 398, 257, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 614, 228, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 570, 246, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 295, 227, 65496, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 518, 259, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 352, 45, 22, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 205, 310, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 110, 299, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 40, 363, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 5, 34, 65468, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 305, 84, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 403, 223, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 392, 246, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 520, 253, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 288, 203, 0, 1238));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 434, 236, 0, 1238));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1232;
                case RoomExit.South: return 1244;
                case RoomExit.East:  return 1239;
                case RoomExit.West:  return 1237;
                default: return 0;
            }
        }
}
}
