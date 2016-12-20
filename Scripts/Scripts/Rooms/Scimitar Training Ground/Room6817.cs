using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6817 : Room
{
public Room6817()
: base(6817, "Scimitar Training Ground")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.UpDownRight;
this.AddRoomDecoration(RoomDecoration.FromCode(2536, 81, 109, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(35304, 253, 109, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(35304, 502, 109, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 600, 168, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 190, 162, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 291, 158, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 338, 158, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 238, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1507, 548, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 645, 197, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 569, 163, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1590, 122, 193, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1591, 99, 208, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1592, 519, 238, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1593, 470, 202, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 217, 194, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 269, 178, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 389, 179, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 268, 215, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1593, 482, 190, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34362, 348, 210, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1591, 164, 190, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1590, 530, 190, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 7, 214, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 585, 173, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 573, 191, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 357, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 413, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 402, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 458, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 488, 251, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 132, 114, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 124, 108, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 15, 218, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 20, 228, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 65526, 221, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 583, 180, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1542, 31, 325, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1545, 602, 188, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 238, 163, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 294, 163, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 340, 162, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 392, 163, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 65525, 179, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 149, 164, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 307, 158, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34353, 329, 157, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 492, 159, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 179, 168, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 128, 176, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 78, 182, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 42, 232, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1545, 13, 170, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 132, 142, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 415, 142, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 529, 142, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 84, 235, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 238, 247, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1585, 129, 258, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 168, 240, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 104, 208, 65496, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 333, 243, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 413, 242, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 311, 250, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34365, 457, 237, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 558, 208, 65496, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 310, 290, 65496, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34365, 532, 224, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 581, 200, 65496, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 576, 200, 65506, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 569, 189, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 218, 114, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 236, 108, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1536, 380, 115, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 346, 87, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1596, 202, 107, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1538, 45, 123, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1508, 509, 123, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 570, 87, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1540, 628, 264, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1536, 624, 112, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1597, 516, 238, 65516, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 316, 110, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 432, 111, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 156, 111, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 265, 112, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 364, 111, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1522, 96, 111, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 189, 110, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 24, 113, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 493, 111, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34289, 531, 110, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34364, 479, 166, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 601, 110, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 624, 117, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 18, 127, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 0, 121, 0, 6817));
this.AddRoomDecoration(RoomDecoration.FromCode(34288, 431, 118, 0, 6817));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 6813;
                default: return 0;
            }
        }
}
}
