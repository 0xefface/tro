using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1556 : Room
{
public Room1556()
: base(1556, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 97, 125, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 283, 130, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 510, 128, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 494, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 595, 143, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 375, 142, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 292, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 224, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 160, 239, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 309, 250, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 578, 245, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 97, 210, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 363, 238, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 79, 206, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 435, 220, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 603, 261, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 326, 235, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 320, 247, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 182, 251, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 154, 237, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 305, 249, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 327, 259, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 374, 255, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 357, 236, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 424, 230, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 610, 262, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 585, 245, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 87, 212, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 72, 199, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 124, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 124, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 133, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 142, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 141, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 140, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 143, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 139, 0, 1556));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 343, 236, 0, 1556));



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
