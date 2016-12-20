using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1494 : Room
{
public Room1494()
: base(1494, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 452, 139, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 144, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 31, 137, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 604, 345, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 206, 291, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 391, 208, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 444, 321, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 201, 274, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 429, 220, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 149, 151, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 149, 152, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 91, 254, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 82, 269, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 134, 283, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 142, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 135, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 142, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 140, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 135, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 413, 209, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 140, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 135, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 138, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 143, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 136, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 136, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 136, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 65535, 94, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 139, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 140, 139, 0, 1494));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 611, 246, 0, 1494));



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
