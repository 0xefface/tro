using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5055 : Room
{
public Room5055()
: base(5055, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 36, 107, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2521, 113, 96, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2522, 93, 109, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(35383, 501, 202, 150, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 714, 6, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 535, 141, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2524, 582, 144, 100, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2511, 446, 165, 150, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 487, 133, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 412, 122, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 474, 133, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2510, 381, 189, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 129, 179, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 199, 165, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 217, 148, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2718, 158, 157, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2749, 65450, 106, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2954, 586, 217, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(35375, 36, 121, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(35376, 65511, 133, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2953, 365, 88, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(2748, 302, 107, 0, 5055));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 170, 0, 5055));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5040;
                case RoomExit.South: return 5070;
                case RoomExit.East:  return 5056;
                case RoomExit.West:  return 5054;
                default: return 0;
            }
        }
}
}
