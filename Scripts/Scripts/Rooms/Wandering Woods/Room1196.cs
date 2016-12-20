using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1196 : Room
{
public Room1196()
: base(1196, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 551, 135, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 125, 140, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 383, 144, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 584, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 339, 314, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 319, 253, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 239, 249, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 320, 252, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 282, 226, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 391, 222, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 134, 119, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 31, 259, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 79, 213, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 49, 207, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 62, 206, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 371, 231, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 250, 254, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 282, 233, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 565, 319, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 165, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 138, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 140, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 144, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 145, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 194, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 69, 194, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 135, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 134, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 133, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 140, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 139, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 143, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32792, 87, 172, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 580, 222, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 416, 227, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 395, 222, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 165, 230, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 184, 226, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 273, 259, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 197, 322, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 42, 194, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 48, 212, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 650, 332, 0, 1196));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 622, 320, 0, 1196));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1190;
                case RoomExit.South: return 1263;
                case RoomExit.East:  return 1197;
                case RoomExit.West:  return 1195;
                default: return 0;
            }
        }
}
}
