using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1523 : Room
{
public Room1523()
: base(1523, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 85, 116, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 541, 126, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 351, 127, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 354, 159, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 190, 119, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 190, 130, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 245, 133, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 450, 222, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 537, 143, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 96, 151, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 30, 129, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 132, 228, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 113, 231, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 442, 227, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 585, 262, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 144, 233, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 56, 326, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 446, 320, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 180, 255, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 590, 255, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1061, 323, 118, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 143, 258, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 312, 105, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 490, 140, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 0, 32924, 524, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 589, 264, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 356, 165, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 61, 324, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(524, 145, 0, 156, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 241, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 293, 116, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 82, 211, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 62, 199, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 198, 218, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 346, 109, 0, 1523));
this.AddRoomDecoration(RoomDecoration.FromCode(32905, 222, 253, 0, 1523));



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
