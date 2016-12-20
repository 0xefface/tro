using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1407 : Room
{
public Room1407()
: base(1407, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 486, 102, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 116, 137, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 135, 104, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 424, 135, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 666, 131, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 265, 113, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 38, 300, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 579, 317, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 26, 312, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 36, 317, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 48, 310, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 308, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 173, 133, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 365, 145, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 464, 144, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 340, 146, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 368, 146, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 386, 146, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 347, 141, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 369, 140, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 140, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 435, 144, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 434, 139, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 114, 138, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 598, 313, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 131, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 134, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 134, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 133, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 135, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 131, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 132, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65520, 328, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 63, 228, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 129, 134, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 131, 103, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 90, 120, 0, 1407));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 123, 38, 0, 1407));



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
