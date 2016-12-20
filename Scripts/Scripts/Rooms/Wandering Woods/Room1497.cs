using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1497 : Room
{
public Room1497()
: base(1497, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 90, 124, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 555, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 329, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 504, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 618, 144, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 98, 138, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 179, 138, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 311, 141, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 385, 143, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 446, 145, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 225, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 348, 259, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 411, 258, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 263, 319, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 524, 247, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 78, 264, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 203, 223, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 475, 237, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 31, 254, 20, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 50, 264, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 273, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 256, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 211, 215, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 222, 231, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 188, 221, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 349, 263, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 433, 272, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 260, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 402, 256, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 435, 250, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 472, 235, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 291, 333, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 262, 325, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 355, 242, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 431, 247, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 26, 261, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 137, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 137, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 137, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 227, 140, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 140, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 141, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 144, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 432, 145, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 145, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 139, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 150, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 150, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 143, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 143, 0, 1497));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 560, 200, 0, 1497));



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
