using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1657 : Room
{
public Room1657()
: base(1657, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 357, 138, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 575, 143, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 488, 148, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 354, 138, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 440, 140, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 449, 316, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 453, 319, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 409, 257, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 222, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 151, 197, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 229, 65516, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 30, 249, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 61, 275, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 113, 199, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 453, 222, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 437, 222, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 143, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 135, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 65, 245, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 35, 206, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 121, 237, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 101, 226, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 172, 236, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 147, 223, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 188, 226, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 195, 222, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 424, 265, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 399, 246, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 613, 337, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 429, 237, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 461, 258, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 63, 293, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 288, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 135, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 144, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 143, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 138, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 139, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 138, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 139, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 388, 139, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 133, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 440, 140, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 139, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 147, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 147, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 63, 203, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 205, 202, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 315, 201, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 435, 199, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 559, 201, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 596, 201, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 273, 205, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 280, 246, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 303, 243, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 289, 204, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(139, 468, 241, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 151, 194, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 110, 202, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 156, 201, 0, 1657));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 119, 193, 0, 1657));



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
