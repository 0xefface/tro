using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1425 : Room
{
public Room1425()
: base(1425, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 407, 205, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 118, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 38, 245, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 262, 221, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 282, 226, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 43, 243, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 430, 113, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 123, 119, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 503, 128, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 264, 123, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 431, 129, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 141, 120, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 259, 224, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 400, 128, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 225, 101, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 122, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 121, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 121, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 124, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 125, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 270, 124, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 128, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 421, 130, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 130, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 129, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 489, 128, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 129, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 126, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 65526, 116, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 21, 112, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 144, 118, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 291, 218, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(102, 510, 318, 0, 1425));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 30, 128, 0, 1425));


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
