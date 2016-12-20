using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1659 : Room
{
public Room1659()
: base(1659, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 461, 139, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 241, 139, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 526, 157, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 387, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 325, 140, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 506, 146, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 29, 199, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 392, 258, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 543, 316, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 97, 197, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 88, 206, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 12, 320, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 320, 249, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 346, 186, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 217, 185, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 573, 320, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 604, 272, 65509, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 548, 183, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 532, 116, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 136, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 208, 111, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 360, 112, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 279, 146, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 163, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 190, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 137, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 482, 238, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 328, 248, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 343, 263, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 42, 207, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 78, 204, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 105, 206, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 65, 208, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 412, 271, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 506, 250, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 480, 235, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 522, 188, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 599, 312, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 551, 182, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 572, 188, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 335, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 577, 327, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 18, 318, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 415, 193, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 128, 206, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 163, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 131, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 136, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 141, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 141, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 138, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 147, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 147, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 140, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 141, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 142, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 141, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 139, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 155, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 133, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 133, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 221, 188, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 78, 209, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 635, 222, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 331, 184, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 308, 184, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 140, 208, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 551, 202, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 570, 200, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 434, 198, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 440, 187, 0, 1659));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 659, 315, 0, 1659));



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
