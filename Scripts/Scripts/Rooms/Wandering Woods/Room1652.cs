using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1652 : Room
{
public Room1652()
: base(1652, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 451, 102, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(952, 610, 103, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 54, 102, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 264, 102, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 364, 109, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 208, 120, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 579, 221, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 477, 96, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 629, 42, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 174, 262, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 17, 324, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 234, 263, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 129, 261, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 25, 324, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 485, 103, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 578, 223, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 498, 101, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 227, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 227, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 227, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 224, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 122, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(33705, 569, 193, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(33722, 591, 127, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 227, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(33702, 511, 134, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 615, 135, 0, 1652));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 573, 203, 0, 1652));



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
