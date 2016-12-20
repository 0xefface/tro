using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1338 : Room
{
public Room1338()
: base(1338, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 344, 138, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 394, 139, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 547, 148, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 125, 136, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 554, 156, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 206, 139, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 319, 138, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 267, 142, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 485, 143, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 162, 127, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 40, 209, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 434, 218, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 568, 253, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 383, 257, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 205, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 528, 255, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 363, 244, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 395, 248, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 603, 245, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 98, 329, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 496, 150, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 494, 118, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 253, 124, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 522, 164, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 557, 169, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 310, 249, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 75, 325, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 42, 206, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 78, 202, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 54, 216, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 91, 215, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65, 338, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 590, 246, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 345, 249, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 329, 262, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 363, 243, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 378, 262, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 447, 229, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 531, 256, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 525, 254, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 502, 154, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 567, 187, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 599, 241, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 125, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 121, 136, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 137, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 195, 140, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 212, 140, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 142, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 141, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 140, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 139, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 139, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 142, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 142, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 126, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 126, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 227, 244, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 264, 257, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 269, 173, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 300, 184, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 281, 182, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 208, 200, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 225, 201, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 425, 173, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 570, 173, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 548, 171, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 304, 261, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 286, 247, 0, 1338));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 359, 237, 0, 1338));


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
