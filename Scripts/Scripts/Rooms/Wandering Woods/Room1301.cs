using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1301 : Room
{
public Room1301()
: base(1301, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 388, 134, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 158, 131, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 450, 144, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 545, 157, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 131, 137, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 629, 248, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 194, 138, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 353, 146, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 289, 143, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 144, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 111, 221, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 216, 323, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 618, 302, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 527, 289, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 478, 235, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 33, 264, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 353, 267, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 508, 203, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 442, 247, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 423, 230, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 384, 223, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 626, 314, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 29, 260, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 613, 322, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 130, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 130, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 144, 137, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 167, 137, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 143, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 143, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 145, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 157, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 549, 185, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 185, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 122, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 93, 216, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 285, 215, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 451, 222, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 461, 219, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 27, 270, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 66, 215, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 100, 216, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 360, 264, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 467, 247, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 436, 236, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 572, 257, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 367, 163, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 346, 160, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 215, 317, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 460, 222, 0, 1301));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 82, 266, 0, 1301));



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
