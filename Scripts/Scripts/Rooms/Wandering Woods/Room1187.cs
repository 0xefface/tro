using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1187 : Room
{
public Room1187()
: base(1187, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 43, 128, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 545, 121, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 280, 130, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 621, 139, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 42, 209, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 428, 218, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 598, 330, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 340, 319, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 70, 205, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 13, 314, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 251, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 371, 225, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 323, 337, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 132, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 141, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 136, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 140, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 141, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 147, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 320, 262, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 138, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 137, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 144, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 131, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 294, 244, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 229, 259, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 164, 238, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 252, 262, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 218, 247, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 229, 254, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 192, 236, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 445, 227, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 272, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 584, 249, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 426, 215, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 221, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 82, 216, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 58, 203, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 329, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 29, 215, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 62, 212, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 404, 219, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 58, 224, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 234, 305, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 7, 256, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 262, 325, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 133, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 254, 200, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 140, 180, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 144, 172, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 30, 168, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 554, 215, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 428, 198, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 404, 201, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 494, 292, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 586, 293, 0, 1187));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 478, 261, 0, 1187));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1181;
                case RoomExit.South: return 1193;
                case RoomExit.East:  return 1188;
                case RoomExit.West:  return 1186;
                default: return 0;
            }
        }
}
}
