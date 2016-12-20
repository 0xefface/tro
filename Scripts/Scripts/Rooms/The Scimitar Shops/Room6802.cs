using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6802 : Room
{
public Room6802()
: base(6802, "The Scimitar Shops")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.UpDownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(3, 282, 172, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 182, 9, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 119, 169, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 211, 100, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 84, 189, 100, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 142, 174, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65494, 175, 65526, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 538, 139, 50, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(34898, 190, 107, 40, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 169, 156, 170, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2106, 311, 181, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2261, 39, 205, 80, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(34888, 425, 109, 10, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 183, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 317, 89, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 39, 22, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 420, 100, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 280, 9, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 376, 9, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 473, 9, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2125, 231, 105, 10, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(35106, 668, 33, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2119, 433, 107, 40, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(35106, 591, 22, 65386, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 518, 169, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 556, 161, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 485, 173, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 338, 173, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 209, 181, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 411, 181, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(2260, 40, 179, 0, 6802));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65519, 215, 0, 6802));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 6813;
                case RoomExit.West:  return 6800;
                default: return 0;
            }
        }
}
}
