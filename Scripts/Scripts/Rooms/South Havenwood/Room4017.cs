using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room4017 : Room
{
public Room4017()
: base(4017, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 328, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 29, 242, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 38, 256, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 51, 117, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 603, 127, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 521, 121, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 126, 115, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 215, 254, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 247, 256, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 208, 255, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 8, 260, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 115, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 116, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 116, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 116, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 113, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 114, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 120, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 120, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 120, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 119, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 126, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 126, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 126, 0, 4017));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 631, 126, 0, 4017));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4012;
                case RoomExit.South: return 4032;
                case RoomExit.East:  return 4017;
                case RoomExit.West:  return 4016;
                default: return 0;
            }
        }
}
}
