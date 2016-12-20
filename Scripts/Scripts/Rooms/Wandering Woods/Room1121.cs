using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1121 : Room
{
public Room1121()
: base(1121, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 78, 114, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 120, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 163, 182, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 268, 105, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 169, 187, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 298, 33, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 128, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 186, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 186, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 187, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 126, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 128, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 127, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 126, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 126, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 181, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 179, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 180, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 184, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 186, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 451, 204, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 473, 216, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 497, 208, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 521, 215, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 563, 208, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 554, 222, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 595, 216, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 499, 222, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 435, 211, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 532, 206, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 528, 229, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 575, 224, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 471, 226, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 540, 219, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 532, 228, 0, 1121));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 631, 220, 0, 1121));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1114;
                case RoomExit.South: return 1128;
                case RoomExit.East:  return 1122;
                case RoomExit.West:  return 1120;
                default: return 0;
            }
        }
}
}
