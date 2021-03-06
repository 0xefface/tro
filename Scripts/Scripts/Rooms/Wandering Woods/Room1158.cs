using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1158 : Room
{
public Room1158()
: base(1158, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 576, 132, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 95, 125, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 362, 131, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 506, 139, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 614, 135, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 65, 135, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 482, 135, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 11, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 292, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 129, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 190, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 546, 134, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 204, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 255, 260, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 469, 229, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 579, 221, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 400, 216, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 211, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 197, 241, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 548, 211, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 591, 220, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 393, 132, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 229, 133, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 436, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 483, 224, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 136, 0, 156, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 69, 216, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 290, 251, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 65, 133, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 133, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 137, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 137, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 137, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 134, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 134, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 134, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 135, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 362, 130, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 136, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 138, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 138, 0, 1158));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 137, 0, 1158));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1152;
                case RoomExit.South: return 1164;
                case RoomExit.East:  return 1159;
                case RoomExit.West:  return 1157;
                default: return 0;
            }
        }
}
}
