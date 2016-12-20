using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3257 : Room
{
public Room3257()
: base(3257, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 372, 104, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 110, 122, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 505, 395, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 365, 41, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 124, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 383, 186, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 501, 185, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 601, 186, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(32983, 267, 192, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 254, 260, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 541, 217, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 432, 217, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 225, 266, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 275, 267, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 326, 215, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 361, 215, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 310, 186, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 612, 217, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 290, 326, 0, 3257));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 230, 326, 0, 3257));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3251;
                case RoomExit.South: return 3262;
                case RoomExit.East:  return 3258;
                case RoomExit.West:  return 3256;
                default: return 0;
            }
        }
}
}
