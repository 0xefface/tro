using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1386 : Room
{
public Room1386()
: base(1386, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 14, 120, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 325, 132, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 140, 133, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 189, 139, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 389, 145, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 276, 140, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 483, 239, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 340, 247, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 582, 326, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 389, 323, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 165, 220, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 20, 256, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 321, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 138, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 600, 206, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 144, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 137, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 262, 133, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 338, 138, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 146, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 149, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 46, 266, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 349, 262, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 416, 264, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 500, 256, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 613, 217, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 405, 258, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 331, 246, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 569, 211, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 363, 336, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 363, 245, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 607, 202, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 144, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 133, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 196, 140, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 132, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 131, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 131, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 141, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 141, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 141, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 146, 0, 1386));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 114, 327, 0, 1386));



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
