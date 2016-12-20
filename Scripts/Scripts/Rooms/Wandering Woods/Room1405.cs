using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1405 : Room
{
public Room1405()
: base(1405, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 516, 118, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 118, 121, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 398, 123, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 497, 128, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 43, 138, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 130, 133, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 498, 122, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 291, 233, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 82, 319, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 274, 230, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 301, 248, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 281, 238, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 295, 243, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 349, 234, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 137, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 136, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 136, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 138, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 103, 132, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 132, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 131, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 131, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 122, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 121, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 413, 122, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 122, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 127, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 127, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 127, 0, 1405));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 127, 0, 1405));



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
