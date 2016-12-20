using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1664 : Room
{
public Room1664()
: base(1664, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 547, 121, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 308, 120, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 253, 146, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 326, 140, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 525, 146, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 523, 215, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 580, 246, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 563, 323, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 113, 252, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 311, 247, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 237, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 145, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 53, 208, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 142, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 488, 218, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 384, 241, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 579, 260, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 493, 217, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 571, 339, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 370, 214, 65516, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 467, 109, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 235, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 237, 249, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 206, 234, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 216, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 26, 202, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 320, 336, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 520, 225, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 138, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 139, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 145, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 131, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 145, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(32899, 595, 320, 0, 1664));
this.AddRoomDecoration(RoomDecoration.FromCode(132, 521, 321, 0, 1664));



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
