using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room5803 : Room
{
public Room5803()
: base(5803, "Arimathor Armory")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2511, 275, 50, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 161, 226, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2714, 156, 226, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2524, 412, 78, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2713, 455, 246, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2626, 319, 171, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2602, 481, 56, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2630, 337, 85, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(35371, 351, 89, 19, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 455, 175, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2601, 234, 14, 65412, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 176, 148, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2509, 405, 188, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2510, 217, 227, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2510, 304, 242, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2629, 249, 156, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2516, 633, 61, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2628, 345, 173, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 143, 225, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(32783, 421, 254, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(35481, 388, 268, 50, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 434, 261, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 410, 255, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 40, 199, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 28, 292, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 30, 171, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 561, 248, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 647, 234, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 637, 242, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 609, 249, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 35, 151, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 169, 304, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 76, 29, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 43, 44, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 24, 15, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 178, 236, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(35464, 647, 113, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2545, 301, 154, 4, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(2542, 301, 153, 65535, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 439, 272, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 233, 237, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 310, 247, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 61, 143, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 58, 115, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 83, 87, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 72, 63, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(34363, 173, 6, 65486, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 139, 227, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 265, 254, 0, 5803));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 391, 275, 0, 5803));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5800;
                case RoomExit.South: return 5807;
                case RoomExit.East:  return 5804;
                case RoomExit.West:  return 21665;
                default: return 0;
            }
        }
}
}
