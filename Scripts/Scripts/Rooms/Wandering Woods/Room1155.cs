using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1155 : Room
{
public Room1155()
: base(1155, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 132, 104, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 116, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 185, 109, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 346, 105, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 521, 239, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 237, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 118, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 120, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 583, 105, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 98, 104, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 543, 236, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 74, 122, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 3, 321, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 122, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 121, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 122, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 122, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 123, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 124, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 367, 105, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 361, 131, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 363, 109, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 363, 149, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 346, 196, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 322, 250, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 354, 229, 0, 1155));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 363, 179, 0, 1155));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1047;
                case RoomExit.South: return 1161;
                case RoomExit.East:  return 4015;
                case RoomExit.West:  return 1154;
                default: return 0;
            }
        }
}
}
