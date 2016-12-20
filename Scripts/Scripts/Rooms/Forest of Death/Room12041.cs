using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12041 : Room
{
public Room12041()
: base(12041, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 90, 124, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 555, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 329, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 504, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 618, 144, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 98, 138, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 179, 138, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 311, 141, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 385, 143, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 446, 145, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 225, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 348, 259, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 411, 258, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 263, 319, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 524, 247, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 120, 270, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 203, 223, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 475, 237, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 79, 255, 20, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 35, 259, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 273, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 256, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 211, 215, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 222, 231, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 188, 221, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 349, 263, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 433, 272, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 260, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 402, 256, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 435, 250, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 472, 235, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 291, 333, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 262, 325, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 355, 242, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 431, 247, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 17, 250, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 137, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 137, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 137, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 227, 140, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 140, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 141, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 144, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 432, 145, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 145, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 139, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 150, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 150, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 143, 0, 12041));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 143, 0, 12041));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12036;
                case RoomExit.South: return 12046;
                case RoomExit.East:  return 12042;
                case RoomExit.West:  return 12040;
                default: return 0;
            }
        }
}
}
