using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1508 : Room
{
public Room1508()
: base(1508, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 547, 121, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 308, 120, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 253, 146, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 207, 139, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 326, 140, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 525, 146, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32816, 522, 209, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 579, 260, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 563, 323, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32882, 26, 207, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 311, 247, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 237, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 122, 240, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 49, 203, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 142, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 487, 212, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 384, 241, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 579, 272, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 490, 208, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 571, 339, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 370, 214, 65516, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 467, 109, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 142, 235, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 237, 249, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 206, 234, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 53, 216, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 26, 202, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 320, 336, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 508, 214, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 138, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 139, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 145, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 102, 131, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 145, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 267, 145, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 552, 219, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 382, 204, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 407, 203, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 268, 202, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 274, 190, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 158, 197, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 140, 193, 0, 1508));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 65525, 208, 0, 1508));



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
