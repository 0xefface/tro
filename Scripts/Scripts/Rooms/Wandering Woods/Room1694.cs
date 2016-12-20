using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1694 : Room
{
public Room1694()
: base(1694, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.DownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 106, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 611, 239, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(163, 119, 167, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 568, 149, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 471, 181, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 473, 180, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 479, 145, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 290, 140, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 562, 322, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(32970, 601, 320, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(201, 507, 332, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(102, 33, 317, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(103, 504, 315, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 154, 168, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 127, 168, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 97, 168, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 187, 161, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 349, 141, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 407, 145, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 227, 143, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 273, 132, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 386, 288, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 652, 175, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 186, 315, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 434, 321, 0, 1694));
this.AddRoomDecoration(RoomDecoration.FromCode(66, 568, 285, 0, 1694));



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
