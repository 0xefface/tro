using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1535 : Room
{
public Room1535()
: base(1535, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 250, 132, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 482, 131, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 450, 138, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 532, 145, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 188, 144, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 414, 136, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 259, 139, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 618, 144, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 31, 206, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 616, 260, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 518, 324, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 247, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 58, 193, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 143, 238, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 216, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 39, 205, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 247, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 186, 143, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 601, 275, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 95, 179, 65516, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 114, 212, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 142, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 143, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 138, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 150, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 142, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 69, 177, 65516, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 457, 136, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 137, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 137, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 136, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 408, 135, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 579, 259, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 509, 338, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 293, 250, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 341, 238, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 213, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 237, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 182, 257, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(139, 65496, 337, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 65511, 297, 0, 1535));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 65524, 302, 0, 1535));



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
