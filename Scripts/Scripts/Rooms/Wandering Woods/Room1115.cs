using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1115 : Room
{
public Room1115()
: base(1115, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 29, 319, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 603, 326, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 402, 226, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 137, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 135, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 136, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 136, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 135, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 137, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 136, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 135, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 137, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 136, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 132, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 612, 132, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 122, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 143, 122, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 119, 122, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 132, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 121, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 122, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 50, 123, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 27, 122, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 99, 205, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 90, 199, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 201, 200, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 240, 218, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 262, 209, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 393, 247, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 335, 242, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 342, 251, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 351, 261, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 373, 273, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 461, 303, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 450, 289, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 475, 293, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(2716, 517, 309, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 393, 301, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 225, 240, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 241, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 139, 199, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 229, 201, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 266, 241, 0, 1115));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 277, 245, 0, 1115));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1109;
                case RoomExit.South: return 1122;
                case RoomExit.East:  return 1116;
                case RoomExit.West:  return 1114;
                default: return 0;
            }
        }
}
}
