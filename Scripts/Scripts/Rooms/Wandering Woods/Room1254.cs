using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1254 : Room
{
public Room1254()
: base(1254, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 43, 128, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 559, 122, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 280, 130, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 621, 139, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 42, 209, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 441, 219, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 598, 330, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 443, 220, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 70, 205, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 15, 317, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 257, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 133, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 474, 226, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 132, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 141, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 136, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 140, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 141, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 138, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 147, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 138, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 137, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 144, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 131, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 138, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 58, 210, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 7, 256, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 588, 259, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 29, 215, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 95, 214, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 470, 225, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 117, 218, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 73, 318, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 255, 132, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 129, 214, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 207, 128, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 309, 146, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 622, 285, 0, 1254));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 651, 285, 0, 1254));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
