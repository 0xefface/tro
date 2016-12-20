using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1418 : Room
{
public Room1418()
: base(1418, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 114, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 520, 110, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 383, 255, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 454, 261, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 612, 121, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 566, 123, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 331, 252, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 43, 129, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 425, 121, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 110, 136, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 338, 271, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 367, 275, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 450, 277, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 128, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 128, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 128, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 128, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 134, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 134, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 409, 120, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 120, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 122, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 122, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 122, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 120, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 120, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 593, 197, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 425, 200, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 264, 210, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 3, 229, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 263, 213, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 281, 206, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 273, 244, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 246, 234, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 129, 227, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 124, 218, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 80, 244, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 119, 238, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 207, 228, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 181, 235, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 134, 241, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(231, 280, 205, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 128, 318, 0, 1418));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 72, 406, 0, 1418));



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
