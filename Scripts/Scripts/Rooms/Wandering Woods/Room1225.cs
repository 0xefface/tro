using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1225 : Room
{
public Room1225()
: base(1225, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 527, 114, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 500, 275, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 402, 280, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 507, 268, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 427, 1, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 128, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 128, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 127, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 102, 121, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 125, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 206, 126, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 129, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 129, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 128, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 127, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 127, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 128, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 592, 217, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 429, 222, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 248, 232, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 231, 235, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 351, 228, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 84, 240, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 48, 248, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 552, 222, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 182, 286, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 365, 283, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 227, 280, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 438, 269, 0, 1225));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 550, 272, 0, 1225));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1219;
                case RoomExit.South: return 1231;
                case RoomExit.East:  return 1226;
                case RoomExit.West:  return 1224;
                default: return 0;
            }
        }
}
}
