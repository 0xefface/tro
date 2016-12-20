using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5072 : Room
{
public Room5072()
: base(5072, "Top Tonsorial")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2614, 113, 122, 56, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2526, 272, 53, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2633, 270, 84, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 61, 38, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 388, 48, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 160, 48, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 490, 41, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 438, 206, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 184, 84, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35382, 432, 121, 56, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(43, 106, 201, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2624, 403, 72, 65526, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2548, 79, 165, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 386, 165, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 161, 165, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 148, 80, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 385, 162, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 160, 162, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 219, 208, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 79, 159, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 325, 209, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2547, 452, 186, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65480, 35, 65456, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 469, 159, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 377, 118, 50, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 284, 116, 50, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 184, 118, 50, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2631, 368, 84, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 24, 222, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 93, 209, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 136, 212, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 171, 212, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 213, 216, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 500, 198, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 464, 206, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 418, 216, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 383, 216, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 338, 220, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 42, 219, 100, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 18, 215, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 62, 216, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 51, 202, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 149, 237, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 387, 233, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 181, 230, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 363, 230, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 146, 223, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 409, 219, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 214, 146, 0, 5072));
this.AddRoomDecoration(RoomDecoration.FromCode(2737, 337, 146, 0, 5072));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5057;
                case RoomExit.South: return 5087;
                case RoomExit.East:  return 5073;
                case RoomExit.West:  return 5071;
                default: return 0;
            }
        }
}
}
