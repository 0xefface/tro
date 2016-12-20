using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1458 : Room
{
public Room1458()
: base(1458, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 427, 124, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 165, 122, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 143, 140, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 133, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 34, 195, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 357, 245, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 437, 244, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 93, 196, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 108, 260, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 87, 191, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 173, 247, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 537, 227, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 614, 268, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 196, 265, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 171, 268, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 185, 260, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 169, 226, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 333, 253, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 376, 258, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 353, 237, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 439, 249, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 264, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 88, 264, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 36, 197, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 70, 198, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 27, 203, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 144, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 144, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 151, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 151, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 142, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 633, 143, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 140, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 132, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 131, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 601, 194, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 468, 196, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 61, 195, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 152, 196, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 343, 197, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 270, 107, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(33000, 260, 139, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(33000, 263, 113, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 267, 157, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 243, 238, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 273, 241, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(32977, 253, 192, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 120, 230, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 201, 229, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 313, 230, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 421, 230, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 24, 229, 0, 1458));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 611, 229, 0, 1458));



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
