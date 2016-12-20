using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1262 : Room
{
public Room1262()
: base(1262, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 417, 124, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 299, 133, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 131, 120, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 428, 223, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 39, 209, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 261, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 39, 212, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 196, 252, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 259, 253, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 605, 187, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 212, 258, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 449, 228, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 611, 275, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(327, 140, 0, 156, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 236, 259, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 261, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 131, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 132, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 126, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 139, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 141, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 138, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 147, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 147, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 147, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 139, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 144, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 144, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 144, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(221, 317, 145, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 276, 125, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 492, 185, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(33015, 352, 175, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 298, 174, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 386, 165, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 532, 217, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 299, 155, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 412, 218, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 313, 172, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 265, 136, 0, 1262));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 618, 219, 0, 1262));



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
