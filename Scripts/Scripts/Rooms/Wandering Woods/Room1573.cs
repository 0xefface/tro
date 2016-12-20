using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1573 : Room
{
public Room1573()
: base(1573, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 160, 123, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 368, 133, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 526, 145, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 630, 144, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 156, 121, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 165, 130, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 389, 141, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 322, 139, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 456, 144, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 28, 214, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 476, 238, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 619, 234, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 542, 228, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 94, 212, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 12, 322, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 560, 254, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 592, 253, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 140, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 143, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 249, 143, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 251, 141, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 144, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 143, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 141, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 143, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 142, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 132, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 132, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 132, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 140, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 602, 256, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 596, 233, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 355, 249, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 420, 233, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 533, 239, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 88, 197, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 74, 299, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 554, 211, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 523, 298, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 155, 278, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 205, 307, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 265, 133, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 323, 138, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 140, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 132, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 144, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 129, 0, 1573));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 129, 0, 1573));



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
