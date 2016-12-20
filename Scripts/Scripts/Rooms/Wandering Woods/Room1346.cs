using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1346 : Room
{
public Room1346()
: base(1346, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 547, 121, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 308, 120, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 253, 146, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 326, 140, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 525, 146, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 509, 201, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 579, 254, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 607, 319, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 109, 241, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 322, 246, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 145, 246, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 213, 245, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 212, 239, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 50, 201, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 142, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 474, 203, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 384, 241, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 574, 250, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 462, 198, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 571, 339, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 370, 214, 65516, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 467, 109, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 235, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 237, 249, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 206, 234, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 216, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 37, 204, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 320, 336, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 498, 203, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 138, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 139, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 145, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 131, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 145, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 145, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 84, 205, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 270, 204, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 464, 206, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 462, 203, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32883, 537, 204, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 514, 198, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 448, 206, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 598, 208, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 531, 251, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 526, 245, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 601, 256, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 140, 249, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 64, 203, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 245, 227, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 268, 228, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 318, 243, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 337, 251, 0, 1346));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 205, 255, 0, 1346));



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
