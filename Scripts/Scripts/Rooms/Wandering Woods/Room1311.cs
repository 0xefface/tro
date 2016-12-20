using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1311 : Room
{
public Room1311()
: base(1311, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 476, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 536, 148, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 608, 147, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 353, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 415, 141, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 181, 203, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 72, 357, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 184, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 220, 225, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 200, 202, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 45, 201, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 27, 203, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 97, 244, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 113, 241, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 146, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 56, 203, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 366, 206, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 118, 237, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 127, 239, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 222, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 182, 235, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 198, 223, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 238, 235, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 569, 219, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 547, 208, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 413, 259, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 397, 244, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 220, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 41, 206, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 631, 293, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 273, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 581, 313, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 616, 327, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 227, 204, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 128, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 137, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 301, 127, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 127, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 454, 139, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 480, 137, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 147, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 479, 206, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 571, 206, 0, 1311));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 569, 205, 0, 1311));



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
