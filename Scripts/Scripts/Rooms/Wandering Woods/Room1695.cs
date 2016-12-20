using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1695 : Room
{
public Room1695()
: base(1695, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(196, 131, 137, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 132, 138, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 92, 194, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 170, 104, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(163, 331, 133, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 550, 130, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 226, 117, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 257, 123, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 294, 134, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 470, 132, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 372, 136, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 539, 123, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 622, 121, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 135, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 132, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 159, 332, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(201, 229, 325, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 94, 334, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(109, 115, 323, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 326, 326, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 609, 334, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 502, 332, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 595, 328, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 437, 322, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 120, 145, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(191, 74, 230, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 29, 286, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 132, 107, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 96, 116, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 123, 34, 0, 1695));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 44, 272, 0, 1695));



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
