using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5042 : Room
{
public Room5042()
: base(5042, "Ivory Moon Cafe")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 427, 3, 65437, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 75, 1, 65437, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 547, 2, 65437, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2745, 206, 1, 65437, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 267, 195, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 608, 176, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 501, 173, 65526, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(86, 498, 174, 43, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 452, 259, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 121, 127, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 194, 117, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 404, 116, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 481, 121, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 643, 185, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 564, 115, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 180, 100, 0, 5042));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 482, 116, 0, 5042));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5027;
                case RoomExit.South: return 5057;
                case RoomExit.East:  return 5043;
                case RoomExit.West:  return 5041;
                default: return 0;
            }
        }
}
}
