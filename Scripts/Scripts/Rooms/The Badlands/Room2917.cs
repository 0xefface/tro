using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2917 : Room
{
public Room2917()
: base(2917, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(12311, 321, 0, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 43, 150, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 540, 470, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(35486, 493, 236, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 311, 149, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 214, 141, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 269, 140, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 160, 143, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 11, 180, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 585, 283, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 435, 143, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 231, 160, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 415, 142, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 231, 143, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 446, 144, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 162, 144, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 295, 142, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 399, 142, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 345, 141, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 325, 141, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 372, 140, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 419, 141, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 444, 143, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 240, 144, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(32891, 389, 141, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(32891, 148, 142, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 327, 137, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 192, 140, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 285, 147, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 338, 149, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 277, 156, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 334, 156, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 555, 286, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 612, 306, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 494, 303, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 75, 304, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 74, 308, 0, 2917));
this.AddRoomDecoration(RoomDecoration.FromCode(128, 473, 302, 0, 2917));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2912;
                case RoomExit.South: return 2922;
                case RoomExit.East:  return 2918;
                case RoomExit.West:  return 2916;
                default: return 0;
            }
        }
}
}
