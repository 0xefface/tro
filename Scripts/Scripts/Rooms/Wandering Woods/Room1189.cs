using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1189 : Room
{
public Room1189()
: base(1189, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 417, 124, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 299, 133, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 136, 119, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 27, 125, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 435, 207, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 35, 209, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 261, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 578, 273, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 39, 212, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 140, 259, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 167, 255, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 311, 244, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 456, 207, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 212, 258, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 449, 228, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 611, 275, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(327, 140, 0, 156, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 236, 261, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 261, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 131, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 132, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 126, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 139, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 141, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 138, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 147, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 147, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 147, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 139, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 144, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 144, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 144, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 282, 126, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 364, 149, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 259, 134, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 383, 173, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 357, 272, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32989, 359, 231, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 442, 205, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 448, 239, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 461, 208, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 344, 212, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 403, 213, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 336, 239, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 238, 212, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 555, 215, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 54, 212, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 39, 220, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 221, 217, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 557, 204, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 390, 263, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 365, 189, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 326, 288, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 387, 288, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 393, 209, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 340, 172, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 301, 155, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 151, 261, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 174, 256, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 117, 114, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 132, 106, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 115, 104, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 257, 105, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 15, 84, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 191, 88, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 408, 326, 0, 1189));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 349, 327, 0, 1189));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1183;
                case RoomExit.South: return 1195;
                case RoomExit.East:  return 1190;
                case RoomExit.West:  return 1188;
                default: return 0;
            }
        }
}
}
