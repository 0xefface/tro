using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1109 : Room
{
public Room1109()
: base(1109, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 440, 102, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 683, 104, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 145, 103, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 100, 116, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 677, 128, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 471, 209, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 598, 28, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 127, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 259, 126, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 128, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 197, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 471, 208, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 129, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 128, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 300, 103, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 243, 202, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 121, 226, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 105, 216, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 239, 191, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 299, 125, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 303, 188, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 306, 181, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 305, 165, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 319, 168, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 308, 172, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 319, 178, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 315, 188, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 309, 198, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 167, 262, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 48, 263, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 213, 217, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 51, 218, 0, 1109));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 495, 205, 0, 1109));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1104;
                case RoomExit.South: return 1115;
                case RoomExit.East:  return 1110;
                case RoomExit.West:  return 1108;
                default: return 0;
            }
        }
}
}
