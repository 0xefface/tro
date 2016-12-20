using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5076 : Room
{
public Room5076()
: base(5076, "Troll Bragger Inn")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 155, 14, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2613, 65489, 169, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(35383, 65482, 204, 150, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 214, 29, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 230, 51, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2525, 412, 30, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2617, 400, 49, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2527, 309, 53, 50, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2618, 309, 92, 50, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 52, 185, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 270, 175, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2588, 377, 175, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 286, 147, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 393, 147, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 27, 167, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 172, 194, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 7, 202, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 27, 202, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 501, 191, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 484, 188, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2700, 283, 54, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 332, 205, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 432, 206, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65521, 203, 65506, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 218, 203, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 38, 135, 65446, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 38, 216, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 406, 206, 0, 5076));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 255, 206, 0, 5076));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5061;
                case RoomExit.South: return 4001;
                case RoomExit.East:  return 5077;
                case RoomExit.West:  return 5075;
                default: return 0;
            }
        }
}
}
