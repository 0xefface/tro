using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1227 : Room
{
public Room1227()
: base(1227, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(176, 314, 103, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65532, 104, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 65496, 102, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 1, 118, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 547, 123, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 122, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(33009, 307, 11, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 120, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 492, 194, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 491, 193, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(33013, 235, 7, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 165, 103, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 163, 212, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 316, 205, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 390, 212, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 532, 212, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 243, 213, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 281, 105, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 275, 129, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 276, 107, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 280, 158, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 264, 154, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 267, 202, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 312, 198, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 265, 191, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 324, 198, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 246, 200, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 25, 212, 0, 1227));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 611, 213, 0, 1227));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1221;
                case RoomExit.South: return 1233;
                case RoomExit.East:  return 1228;
                case RoomExit.West:  return 1226;
                default: return 0;
            }
        }
}
}
