using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1680 : Room
{
public Room1680()
: base(1680, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 181, 139, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 241, 141, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 525, 145, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 115, 132, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 474, 236, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 497, 235, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 330, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 93, 214, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 3, 319, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 416, 236, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 142, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 333, 254, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 58, 216, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 334, 269, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 413, 260, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 449, 250, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 491, 252, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 296, 264, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 131, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 138, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 138, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 138, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 231, 140, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 140, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 144, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 140, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 139, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 143, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 143, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 149, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 149, 0, 1680));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 596, 142, 0, 1680));



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
