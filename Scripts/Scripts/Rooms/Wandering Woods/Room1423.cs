using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1423 : Room
{
public Room1423()
: base(1423, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 290, 103, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 105, 116, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 512, 230, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 515, 229, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 4, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 105, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 82, 104, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 459, 106, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 29, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 119, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 143, 126, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 128, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 129, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 55, 182, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 193, 186, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 460, 247, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 619, 244, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 357, 247, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 119, 214, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 135, 174, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 261, 215, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 263, 222, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 377, 275, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 327, 261, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 383, 297, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 15, 213, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 535, 274, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(215, 315, 193, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 536, 296, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 627, 210, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 660, 201, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 626, 297, 0, 1423));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 625, 273, 0, 1423));



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
