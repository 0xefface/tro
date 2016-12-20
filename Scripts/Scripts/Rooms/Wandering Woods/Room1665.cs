using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1665 : Room
{
public Room1665()
: base(1665, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 388, 134, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 450, 144, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 545, 157, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 234, 128, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 555, 186, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 173, 125, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 353, 146, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 289, 143, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 512, 144, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 397, 348, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 645, 268, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 610, 255, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 484, 232, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 161, 272, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 327, 247, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 126, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 439, 243, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 593, 206, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 630, 210, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 34, 359, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 333, 263, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 595, 295, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 180, 128, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 128, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 227, 129, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 129, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 143, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 142, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 143, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 145, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 145, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 157, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 549, 185, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 185, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32871, 626, 317, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 113, 263, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65534, 321, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 127, 139, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 127, 138, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 164, 285, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 74, 224, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 92, 121, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 125, 145, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 132, 105, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7902, 138, 39, 0, 1665));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 32, 316, 0, 1665));



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
