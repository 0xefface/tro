using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1586 : Room
{
public Room1586()
: base(1586, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 302, 131, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 503, 142, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 136, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 282, 135, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 145, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 459, 135, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 35, 205, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 288, 245, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 321, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 575, 254, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 513, 327, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 243, 252, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 144, 245, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 213, 272, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 582, 255, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 140, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 133, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 230, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 439, 222, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 422, 215, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 142, 268, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 232, 261, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 551, 332, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 136, 236, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 40, 205, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 63, 205, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 32, 199, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 87, 196, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 573, 263, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 602, 266, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 318, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 580, 328, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 636, 333, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 126, 237, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 211, 241, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 141, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 144, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 441, 357, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 540, 307, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 133, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 144, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 141, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 140, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 144, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 134, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 140, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 133, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 133, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 139, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 133, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 339, 108, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 308, 222, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 322, 228, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 343, 177, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 332, 157, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 354, 177, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 332, 143, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 248, 256, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 293, 279, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 267, 256, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 333, 117, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 299, 280, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 313, 304, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(35480, 506, 257, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 485, 258, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 570, 263, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 87, 246, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 143, 273, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 65525, 165, 0, 1586));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 628, 249, 0, 1586));



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
