using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room150000002 : Room
{
public Room150000002()
: base(150000002, "Outside Kappy's House")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.LongGrassySunnyDay;
this.BlockedRoomExits = BlockedExits.UpLeftRight;
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 435, 12, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 556, 30, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 486, 34, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 341, 32, 20, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2513, 208, 34, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2514, 276, 83, 50, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2508, 59, 20, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2621, 296, 40, 20, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2623, 270, 52, 30, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2627, 479, 47, 30, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 508, 63, 40, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2999, 314, 136, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 454, 241, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 394, 179, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 406, 201, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2997, 463, 221, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 41, 187, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 10, 173, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 139, 185, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 577, 216, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 367, 222, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 594, 238, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2957, 375, 259, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 226, 174, 20, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 201, 136, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 102, 158, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 91, 139, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 432, 120, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 443, 159, 20, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2974, 274, 116, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 699, 12, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2614, 604, 120, 100, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(35382, 164, 124, 100, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2957, 363, 212, 65516, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 401, 172, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 48, 204, 0, 150000002));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 439, 193, 0, 150000002));


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
