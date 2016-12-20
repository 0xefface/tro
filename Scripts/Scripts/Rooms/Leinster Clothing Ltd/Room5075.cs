using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5075 : Room
{
public Room5075()
: base(5075, "Leinster Clothing Ltd.")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.DownLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(2615, 201, 126, 150, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 308, 145, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2502, 419, 65, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2586, 635, 131, 65486, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2592, 610, 131, 65504, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 431, 79, 20, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 330, 39, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 365, 202, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 485, 188, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 417, 62, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 593, 243, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 380, 73, 20, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2593, 474, 169, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 243, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 612, 243, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2587, 319, 164, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(35482, 238, 170, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 276, 39, 65386, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 540, 235, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2717, 613, 239, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(35485, 495, 234, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2691, 557, 179, 15, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2501, 495, 41, 65516, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2520, 639, 44, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 411, 70, 10, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 541, 95, 20, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2708, 554, 148, 20, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 227, 195, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 470, 69, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 268, 94, 65436, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 358, 227, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 603, 262, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 2, 157, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 2, 234, 0, 5075));
this.AddRoomDecoration(RoomDecoration.FromCode(2534, 4, 342, 0, 5075));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5060;
                case RoomExit.South: return 4000;
                case RoomExit.East:  return 5076;
                case RoomExit.West:  return 1041;
                default: return 0;
            }
        }
}
}
