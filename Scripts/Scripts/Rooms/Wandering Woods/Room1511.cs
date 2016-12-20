using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1511 : Room
{
public Room1511()
: base(1511, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 388, 134, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 158, 131, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 450, 144, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 545, 157, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 131, 137, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 555, 186, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 194, 138, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 353, 146, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 289, 143, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 144, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 111, 221, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 210, 221, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 645, 268, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 610, 255, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 484, 232, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 25, 257, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 327, 247, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 256, 212, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 439, 243, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 593, 206, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 630, 210, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 633, 322, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 343, 258, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 439, 265, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 400, 238, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 430, 231, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 326, 245, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 516, 259, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 595, 295, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 633, 301, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 613, 269, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 626, 246, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 228, 230, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 107, 219, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 133, 226, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 48, 269, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 130, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 130, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 144, 137, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 167, 137, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 143, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 143, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 145, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 157, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 549, 185, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 185, 0, 1511));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 122, 0, 1511));



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
