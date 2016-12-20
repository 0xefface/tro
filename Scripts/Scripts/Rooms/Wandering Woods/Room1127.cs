using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1127 : Room
{
public Room1127()
: base(1127, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 273, 102, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 410, 103, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 82, 102, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 423, 208, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 431, 209, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65524, 46, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 127, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 129, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 317, 107, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 129, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 410, 204, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 544, 288, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 621, 319, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 554, 324, 0, 1127));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 480, 317, 0, 1127));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1120;
                case RoomExit.South: return 1135;
                case RoomExit.East:  return 1128;
                case RoomExit.West:  return 1126;
                default: return 0;
            }
        }
}
}
