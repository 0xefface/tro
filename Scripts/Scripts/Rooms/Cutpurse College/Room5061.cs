using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5061 : Room
{
public Room5061()
: base(5061, "Cutpurse College")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 65520, 12, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 83, 29, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 57, 39, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 99, 32, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 126, 37, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 222, 12, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 10, 157, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2504, 214, 23, 20, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 401, 140, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 441, 117, 65516, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 78, 204, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 29, 197, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 436, 214, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 129, 220, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 80, 171, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(35570, 89, 186, 100, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(35478, 108, 58, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 122, 54, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 65528, 33, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2622, 437, 80, 120, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 240, 152, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2621, 532, 131, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 442, 226, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(32784, 356, 231, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 430, 238, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 433, 219, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 128, 195, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(16, 363, 227, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 251, 171, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2793, 74, 182, 80, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 0, 138, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 69, 152, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(35369, 419, 136, 0, 5061));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 478, 118, 65516, 5061));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5046;
                case RoomExit.South: return 5076;
                case RoomExit.East:  return 5062;
                case RoomExit.West:  return 5060;
                default: return 0;
            }
        }
}
}
