using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1670 : Room
{
public Room1670()
: base(1670, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 344, 138, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 394, 139, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 547, 148, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 554, 156, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 206, 139, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 319, 138, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 267, 142, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 485, 143, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 424, 203, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 568, 253, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 0, 317, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 72, 326, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 528, 255, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 557, 247, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 3, 315, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 592, 243, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 412, 324, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 496, 150, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 494, 118, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 271, 125, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 522, 164, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 559, 181, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 168, 218, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 204, 267, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 345, 249, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 200, 268, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 531, 256, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 502, 154, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 567, 187, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 599, 241, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 195, 140, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 212, 140, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 142, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 141, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 140, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 139, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 139, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 142, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 142, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 124, 139, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 125, 137, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65528, 322, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 430, 210, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 68, 219, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 115, 148, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 133, 100, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 86, 120, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 131, 36, 0, 1670));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 37, 317, 0, 1670));



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
