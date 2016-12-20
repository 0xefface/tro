using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1516 : Room
{
public Room1516()
: base(1516, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 557, 129, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 266, 136, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 416, 140, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 599, 144, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 536, 142, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 568, 138, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 302, 136, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 212, 143, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 485, 138, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 346, 301, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 511, 323, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 612, 208, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 355, 255, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 205, 218, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 140, 221, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 255, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 106, 237, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 104, 227, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 371, 67, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 39, 268, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 434, 123, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 188, 216, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 403, 254, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 138, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 142, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 135, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 143, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 638, 214, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 119, 237, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 99, 224, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 49, 257, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 156, 221, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 593, 214, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 134, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 143, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 143, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 22, 147, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 146, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 136, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 136, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 136, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 135, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 420, 135, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 134, 0, 1516));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 140, 0, 1516));



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
