using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1426 : Room
{
public Room1426()
: base(1426, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 505, 112, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 70, 109, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 147, 320, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 175, 316, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 252, 313, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 338, 105, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 122, 118, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 229, 116, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 143, 317, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 273, 116, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 206, 305, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 194, 311, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 118, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 118, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 118, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 118, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 117, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 262, 119, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 317, 108, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 341, 126, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 390, 250, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 372, 200, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 316, 114, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 345, 131, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 368, 256, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 411, 258, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 416, 180, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 309, 181, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 308, 200, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 383, 197, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 320, 331, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 365, 334, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 426, 331, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 316, 109, 0, 1426));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 329, 176, 0, 1426));



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
