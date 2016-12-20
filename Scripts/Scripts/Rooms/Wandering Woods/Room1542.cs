using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1542 : Room
{
public Room1542()
: base(1542, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 307, 122, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 457, 133, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 138, 126, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 569, 150, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 319, 250, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 37, 201, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 607, 269, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 261, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 61, 193, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 151, 240, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 221, 201, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(32972, 120, 207, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 596, 257, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 558, 124, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 140, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 294, 139, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 129, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 170, 140, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 174, 196, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 24, 237, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 423, 264, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 272, 227, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 69, 207, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 50, 192, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 20, 196, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 28, 208, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 148, 238, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 171, 247, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 301, 265, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 294, 252, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 264, 271, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 623, 277, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 585, 256, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 144, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 416, 195, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 455, 200, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 409, 215, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(27, 201, 0, 49, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 395, 206, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 27, 201, 0, 1542));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 477, 179, 65506, 1542));



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
