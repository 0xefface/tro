using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1432 : Room
{
public Room1432()
: base(1432, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 29, 225, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65, 194, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 86, 181, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 373, 103, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 0, 123, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 479, 118, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 6, 126, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 592, 111, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 350, 125, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 38, 184, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 646, 155, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 468, 129, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 637, 142, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 167, 124, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 88, 182, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 58, 195, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 70, 220, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 36, 231, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 15, 218, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 48, 208, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 178, 122, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 30, 126, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 126, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 123, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 123, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 129, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 129, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 129, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 128, 0, 1432));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 636, 293, 0, 1432));



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
