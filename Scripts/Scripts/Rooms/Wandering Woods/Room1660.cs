using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1660 : Room
{
public Room1660()
: base(1660, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(223, 147, 253, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 528, 121, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 374, 124, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 143, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 270, 149, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 154, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 182, 122, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 364, 125, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 408, 147, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 192, 235, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 579, 240, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 19, 333, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 571, 240, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 616, 278, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 216, 283, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 122, 290, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 189, 234, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 56, 338, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 153, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 307, 259, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 146, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 142, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 124, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 131, 137, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 242, 151, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 153, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 123, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 151, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 271, 150, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 137, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 142, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 144, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 146, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 136, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 108, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 84, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 139, 240, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 218, 245, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 246, 255, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 243, 231, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 555, 242, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 170, 223, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 132, 139, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65531, 321, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 295, 109, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 127, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 126, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65, 234, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 122, 153, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 146, 100, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 97, 120, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 133, 38, 0, 1660));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 36, 316, 0, 1660));



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
