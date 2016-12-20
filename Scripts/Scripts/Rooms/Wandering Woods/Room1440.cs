using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1440 : Room
{
public Room1440()
: base(1440, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 144, 102, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 534, 114, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 140, 106, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 601, 232, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 550, 233, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 283, 280, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 587, 234, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 512, 235, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 452, 134, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 396, 133, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 374, 122, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 65, 120, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 391, 129, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 153, 131, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 95, 126, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 193, 121, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 116, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 131, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 136, 129, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 145, 131, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 36, 119, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 119, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 118, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 119, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 127, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 127, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 126, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 132, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 132, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 132, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 127, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 129, 128, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 146, 128, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 164, 128, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 181, 126, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(237, 293, 109, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 274, 156, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(239, 307, 227, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 53, 238, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 216, 239, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 83, 283, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 30, 266, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 276, 165, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 311, 221, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 307, 221, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 278, 221, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 295, 274, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 337, 281, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 279, 284, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 142, 267, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 146, 284, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 291, 114, 0, 1440));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 31, 284, 0, 1440));


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
