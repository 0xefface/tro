using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1256 : Room
{
public Room1256()
: base(1256, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65498, 121, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 296, 131, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 383, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 560, 142, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 130, 137, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 277, 142, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 113, 111, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 327, 140, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 521, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 195, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 461, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 293, 316, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 120, 298, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(35719, 309, 234, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 138, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 228, 237, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 184, 229, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 587, 245, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 382, 112, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 336, 244, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 227, 239, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 140, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 609, 119, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 247, 246, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 616, 247, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 61, 334, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 176, 322, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 185, 235, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 569, 265, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 288, 240, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 136, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 136, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 77, 132, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 180, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 141, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 141, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 139, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 113, 0, 1256));
this.AddRoomDecoration(RoomDecoration.FromCode(32794, 530, 249, 0, 1256));



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
