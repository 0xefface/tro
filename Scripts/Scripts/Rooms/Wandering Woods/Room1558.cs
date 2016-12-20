using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1558 : Room
{
public Room1558()
: base(1558, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 127, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 290, 131, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 155, 141, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 248, 138, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 298, 139, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 85, 136, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 43, 241, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 505, 254, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 633, 261, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 70, 244, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 212, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 42, 246, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 277, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 569, 197, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 617, 259, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 198, 139, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 140, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 141, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 22, 319, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 218, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 81, 249, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 381, 277, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 514, 261, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 407, 322, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 141, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 137, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 144, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 139, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 140, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 140, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 137, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 137, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 138, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 138, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 503, 290, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 540, 227, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(20, 470, 274, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 65509, 361, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(32793, 648, 285, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 358, 270, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 462, 201, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 15, 306, 0, 1558));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 112, 212, 0, 1558));



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
