using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room7009 : Room
{
public Room7009()
: base(7009, "Kurz Gatekeeper")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 586, 4, 65485, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 273, 3, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 271, 83, 57, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65506, 22, 65437, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 6, 210, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 589, 210, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 362, 15, 65526, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 23, 160, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 48, 190, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 187, 174, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 324, 72, 65477, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 1, 337, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 552, 209, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 88, 46, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 586, 5, 65468, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 502, 7, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 197, 175, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 143, 65, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 45, 137, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 569, 210, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 281, 191, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 631, 215, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 610, 197, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 130, 326, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(35722, 44, 320, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 238, 184, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 54, 208, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 418, 222, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 554, 214, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 220, 183, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 238, 198, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 615, 97, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 163, 45, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65, 73, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 629, 118, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 75, 61, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2721, 400, 190, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 412, 295, 253, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2608, 336, 285, 253, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 258, 167, 47, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2581, 236, 166, 52, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 506, 131, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(2580, 464, 123, 0, 7009));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 322, 209, 0, 7009));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 7003;
                case RoomExit.South: return 7015;
                case RoomExit.East:  return 7010;
                case RoomExit.West:  return 7008;
                default: return 0;
            }
        }
}
}
