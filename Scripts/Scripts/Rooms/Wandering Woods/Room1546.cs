using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1546 : Room
{
public Room1546()
: base(1546, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 245, 118, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 464, 125, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 114, 123, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 413, 130, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 600, 134, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 118, 184, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 565, 140, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 188, 125, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 226, 133, 6, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 133, 123, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 75, 130, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 235, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 473, 245, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 597, 245, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 436, 189, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 83, 217, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 126, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 129, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 566, 284, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 84, 218, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 126, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 445, 129, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 126, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 183, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 134, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 272, 105, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 217, 242, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 401, 289, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 336, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 495, 253, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 99, 223, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 75, 215, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 192, 233, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 414, 192, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 379, 226, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 520, 287, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 577, 285, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 575, 247, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 596, 257, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 137, 194, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 144, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 183, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 350, 102, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 208, 111, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 126, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 183, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 219, 113, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 297, 101, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 128, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 144, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 354, 155, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 350, 152, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 341, 150, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 128, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 322, 148, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 302, 145, 0, 1546));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 215, 227, 0, 1546));



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
