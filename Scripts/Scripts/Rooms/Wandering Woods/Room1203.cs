using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1203 : Room
{
public Room1203()
: base(1203, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 125, 115, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 232, 219, 65526, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 238, 215, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 220, 214, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 463, 1, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 116, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 117, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 118, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 117, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 118, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 119, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 118, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 41, 174, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 218, 225, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 86, 225, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 600, 232, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 131, 221, 65526, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 455, 229, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 145, 274, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 151, 259, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 54, 243, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 65532, 208, 65526, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 281, 276, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 283, 250, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 340, 212, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 333, 289, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 13, 207, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 417, 274, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 687, 230, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 616, 222, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 9, 225, 65526, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(209, 343, 223, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 417, 255, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 515, 277, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 515, 257, 0, 1203));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 335, 205, 0, 1203));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4048;
                case RoomExit.South: return 1209;
                case RoomExit.East:  return 1204;
                case RoomExit.West:  return 1202;
                default: return 0;
            }
        }
}
}
