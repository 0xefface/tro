using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1152 : Room
{
public Room1152()
: base(1152, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 403, 259, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 443, 263, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 193, 104, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 234, 104, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 68, 115, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 65533, 120, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 526, 127, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 230, 105, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 616, 124, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 70, 187, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 603, 286, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 76, 193, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 44, 189, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(32879, 87, 188, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 126, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 126, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 119, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1152));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 658, 325, 0, 1152));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1044;
                case RoomExit.South: return 1158;
                case RoomExit.East:  return 1153;
                case RoomExit.West:  return 1151;
                default: return 0;
            }
        }
}
}
