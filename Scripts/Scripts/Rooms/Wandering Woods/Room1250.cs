using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1250 : Room
{
public Room1250()
: base(1250, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 134, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 452, 139, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 144, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 31, 137, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 604, 345, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 166, 283, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 391, 208, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 444, 321, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 201, 274, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 429, 220, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 149, 151, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 134, 119, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 149, 152, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 91, 254, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 82, 269, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 134, 283, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 142, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 135, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 142, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 140, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 135, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 410, 217, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 140, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 135, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 138, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 143, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 136, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 136, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 136, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 65535, 94, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 139, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 140, 139, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 74, 208, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 280, 208, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 472, 217, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 566, 218, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 331, 234, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 306, 231, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 506, 208, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(28, 586, 128, 0, 1250));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 608, 251, 0, 1250));



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
