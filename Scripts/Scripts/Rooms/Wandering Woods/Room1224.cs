using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1224 : Room
{
public Room1224()
: base(1224, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 273, 102, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 410, 103, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 82, 102, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 449, 197, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 441, 194, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65524, 46, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 127, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 129, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 317, 107, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 129, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 596, 213, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 590, 198, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 454, 205, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 476, 198, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 493, 199, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 360, 194, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 246, 194, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 130, 194, 0, 1224));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 40, 193, 0, 1224));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1218;
                case RoomExit.South: return 1230;
                case RoomExit.East:  return 1225;
                case RoomExit.West:  return 1197;
                default: return 0;
            }
        }
}
}
