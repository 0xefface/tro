using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1154 : Room
{
public Room1154()
: base(1154, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 609, 321, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 255, 102, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 465, 102, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 366, 122, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 44, 134, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 597, 133, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 125, 125, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 431, 129, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 184, 121, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 61, 179, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 79, 184, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 187, 120, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 137, 123, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 422, 127, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 474, 125, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 196, 118, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 568, 260, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 558, 274, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 558, 261, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 133, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 133, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 133, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 125, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 125, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 180, 121, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 120, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 119, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 340, 122, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 363, 121, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 124, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 122, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 421, 129, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 129, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 130, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 131, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 65530, 336, 0, 1154));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 647, 322, 0, 1154));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1046;
                case RoomExit.South: return 1160;
                case RoomExit.East:  return 1155;
                case RoomExit.West:  return 1153;
                default: return 0;
            }
        }
}
}
