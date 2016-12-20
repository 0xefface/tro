using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5025 : Room
{
public Room5025()
: base(5025, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 161, 141, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 33, 161, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 101, 162, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 156, 161, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 156, 220, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 122, 220, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 59, 220, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 25, 220, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 483, 159, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 543, 159, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 603, 159, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 467, 147, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 299, 149, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 317, 162, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 337, 148, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 611, 224, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 555, 223, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 486, 225, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 318, 180, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 319, 198, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 339, 230, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 295, 230, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 158, 222, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 482, 228, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 320, 217, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 410, 92, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 480, 243, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 157, 129, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 157, 114, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 157, 99, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 156, 90, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 199, 93, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 235, 93, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 242, 84, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 464, 87, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 404, 85, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 475, 128, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 476, 115, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 474, 99, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 162, 236, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 161, 255, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 481, 260, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 219, 289, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 162, 274, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 154, 292, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 483, 289, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 483, 272, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 407, 289, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 245, 290, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 471, 86, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 392, 291, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 242, 76, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 402, 73, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 243, 60, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 402, 63, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 241, 302, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 314, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 241, 331, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 399, 302, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 397, 312, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 398, 326, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 245, 48, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 398, 48, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 455, 300, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 182, 296, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 93, 69, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 608, 92, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 38, 92, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 552, 66, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 566, 41, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 78, 41, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 108, 14, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 517, 16, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 24, 205, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 82, 231, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 31, 256, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 104, 280, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 538, 278, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 612, 252, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 565, 227, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(22, 632, 206, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 87, 160, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 544, 158, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 88, 520, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 546, 525, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 212, 92, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 427, 92, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 213, 585, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 429, 584, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 563, 103, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(35479, 616, 323, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 593, 103, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 21, 324, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 96, 223, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 582, 107, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 23, 116, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 508, 138, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 545, 258, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 96, 133, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 490, 71, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 41, 120, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 553, 307, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 598, 301, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(32832, 43, 280, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(64, 25, 288, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 57, 104, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 102, 105, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 258, 218, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 264, 202, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 268, 186, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 268, 168, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 265, 153, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 261, 139, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 376, 222, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 371, 208, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 366, 193, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 366, 175, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 366, 156, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(9, 371, 140, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 244, 585, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 397, 584, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 246, 89, 0, 5025));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 401, 92, 0, 5025));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5010;
                case RoomExit.South: return 5040;
                case RoomExit.East:  return 5026;
                case RoomExit.West:  return 5024;
                default: return 0;
            }
        }
}
}
