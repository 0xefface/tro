using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6807 : Room
{
public Room6807()
: base(6807, "Caster's Cache Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 75, 106, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2108, 552, 172, 65506, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 68, 285, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2020, 158, 28, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 231, 9, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 328, 50, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 429, 8, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 491, 40, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 416, 139, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 199, 139, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 176, 284, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 325, 180, 65516, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 325, 90, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2088, 220, 155, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2088, 436, 155, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 8, 154, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2086, 65531, 180, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2125, 330, 161, 90, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2125, 199, 285, 65, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2129, 323, 194, 65526, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2130, 324, 186, 15, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2131, 85, 286, 50, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2143, 190, 405, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(34911, 448, 364, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(34916, 657, 421, 0, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(34917, 605, 203, 65521, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(34911, 602, 199, 10, 6807));
this.AddRoomDecoration(RoomDecoration.FromCode(2165, 558, 104, 0, 6807));



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
