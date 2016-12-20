using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5814 : Room
{
public Room5814()
: base(5814, "School of Soldiery")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2528, 414, 48, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2529, 319, 85, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2529, 250, 84, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 393, 147, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 240, 147, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 238, 178, 90, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 393, 178, 90, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 240, 181, 65533, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 393, 181, 65533, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 241, 181, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 394, 181, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2528, 213, 46, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65466, 218, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 193, 249, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 270, 251, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 135, 180, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(35482, 40, 197, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2505, 121, 92, 50, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2528, 7, 131, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 365, 250, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 158, 239, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(201, 312, 142, 65436, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2546, 7, 160, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2549, 6, 160, 65533, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 65528, 167, 100, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 145, 130, 50, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2616, 225, 129, 50, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2616, 391, 132, 50, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2616, 317, 133, 50, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(32969, 463, 140, 65436, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(200, 8, 209, 65526, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 172, 132, 65436, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 446, 251, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 23, 223, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 235, 248, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 382, 248, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 65512, 224, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 62, 213, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 5, 300, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 596, 290, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 512, 311, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 673, 261, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 117, 300, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 414, 293, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 351, 304, 0, 5814));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 232, 304, 0, 5814));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5809;
                case RoomExit.South: return 21850;
                case RoomExit.East:  return 5815;
                case RoomExit.West:  return 5813;
                default: return 0;
            }
        }
}
}
