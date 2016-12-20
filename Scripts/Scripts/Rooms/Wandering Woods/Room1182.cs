using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1182 : Room
{
public Room1182()
: base(1182, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65509, 114, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 581, 131, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 369, 130, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 150, 123, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 254, 266, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 350, 251, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 602, 294, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 446, 201, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 248, 259, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 161, 237, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 22, 255, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 166, 269, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 341, 249, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 89, 190, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 50, 192, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 169, 280, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 0, 262, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 277, 219, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 531, 246, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 4, 245, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 611, 325, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 595, 343, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 131, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 131, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 144, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 122, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 122, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 139, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 138, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 145, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 144, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 138, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 135, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 134, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 139, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 139, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 143, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 281, 156, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 176, 113, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 332, 158, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 219, 125, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 256, 126, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 397, 162, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 434, 203, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 604, 203, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 504, 204, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 175, 124, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 460, 205, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 448, 197, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 299, 178, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 315, 154, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 402, 222, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 486, 240, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 547, 239, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 362, 192, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 256, 166, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 226, 146, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 616, 239, 0, 1182));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 193, 126, 0, 1182));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1176;
                case RoomExit.South: return 1188;
                case RoomExit.East:  return 1183;
                case RoomExit.West:  return 1181;
                default: return 0;
            }
        }
}
}
