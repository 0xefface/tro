using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1243 : Room
{
public Room1243()
: base(1243, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(49, 25, 288, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 28, 289, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 430, 273, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 344, 225, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 569, 187, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 444, 188, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 271, 190, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 173, 192, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 64, 192, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 36, 240, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 85, 266, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 73, 305, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 4, 278, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 56, 235, 65528, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 3, 93, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 92, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 509, 223, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 586, 249, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 294, 244, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 23, 287, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 178, 249, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 617, 291, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 464, 274, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 579, 283, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 580, 282, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 51, 191, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 615, 313, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 458, 319, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 460, 301, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 156, 284, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 192, 233, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 166, 266, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 39, 315, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 551, 189, 7, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2333, 185, 197, 149, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2333, 587, 204, 149, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2326, 82, 186, 120, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 252, 189, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 80, 189, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 428, 189, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 571, 190, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 200, 322, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 194, 297, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 436, 271, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 367, 243, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2370, 47, 165, 65486, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 232, 269, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 468, 293, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 423, 256, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 249, 255, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 202, 276, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 177, 298, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 151, 217, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 69, 189, 7, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2333, 455, 202, 149, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2333, 317, 201, 149, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2333, 15, 209, 149, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 230, 276, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 431, 275, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 412, 267, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 395, 257, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 397, 234, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 430, 293, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 508, 287, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 499, 266, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 483, 251, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 466, 238, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 455, 227, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 222, 292, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 250, 262, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 265, 252, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 272, 236, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 45, 172, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 131, 172, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 227, 172, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 322, 172, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 433, 164, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 509, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 579, 165, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 114, 182, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 321, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 465, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 170, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 387, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 240, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 40, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2390, 587, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 519, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2395, 119, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 255, 183, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 392, 182, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 532, 183, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 114, 173, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 255, 175, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 392, 174, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 532, 175, 20, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 114, 173, 40, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 255, 175, 40, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 392, 175, 40, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 532, 175, 40, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 114, 173, 60, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 255, 175, 60, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 392, 176, 60, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 532, 176, 60, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 114, 173, 80, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 255, 175, 80, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 392, 177, 80, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2358, 532, 176, 80, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 114, 173, 100, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 255, 175, 100, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 392, 177, 100, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2361, 532, 176, 100, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 232, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 306, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 400, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2322, 363, 180, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2323, 215, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(35091, 513, 183, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2322, 54, 187, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(2322, 587, 178, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 614, 294, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(63, 320, 175, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 268, 152, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 344, 187, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 222, 311, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 156, 296, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 156, 318, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 430, 312, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 508, 307, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 288, 258, 0, 1243));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 349, 223, 0, 1243));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
