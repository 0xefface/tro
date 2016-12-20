using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1693 : Room
{
public Room1693()
: base(1693, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Down;
this.AddRoomDecoration(RoomDecoration.FromCode(102, 599, 317, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 320, 103, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 549, 166, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 502, 140, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 203, 135, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 61, 117, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 65531, 368, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 96, 141, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 127, 142, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 225, 139, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 170, 141, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 257, 138, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 289, 137, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 318, 136, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 384, 139, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 413, 142, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 445, 143, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 473, 143, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 501, 141, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 535, 166, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 32, 122, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 70, 323, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 164, 224, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 513, 169, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 128, 224, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 215, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 3, 316, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 526, 251, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 398, 325, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 106, 355, 0, 1693));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 383, 354, 0, 1693));



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
