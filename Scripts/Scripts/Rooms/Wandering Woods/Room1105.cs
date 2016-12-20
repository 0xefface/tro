using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1105 : Room
{
public Room1105()
: base(1105, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(165, 523, 111, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 151, 112, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 34, 315, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 30, 162, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 304, 105, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 467, 325, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 239, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 601, 240, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 325, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 561, 325, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 7, 163, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 246, 107, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 491, 111, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(243, 340, 28, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 135, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 5, 161, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 82, 135, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 66, 136, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 136, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 136, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 29, 181, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 70, 189, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 189, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 206, 205, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 336, 194, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 489, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 575, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 608, 229, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 606, 231, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 564, 234, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 247, 221, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 400, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 434, 225, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 540, 226, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 211, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 297, 195, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 18, 294, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 218, 226, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 335, 224, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 492, 196, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 246, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 5, 186, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 41, 197, 0, 1105));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 92, 209, 0, 1105));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1102;
                case RoomExit.South: return 1110;
                case RoomExit.East:  return 1106;
                case RoomExit.West:  return 1104;
                default: return 0;
            }
        }
}
}
