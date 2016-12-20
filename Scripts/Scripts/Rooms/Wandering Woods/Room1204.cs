using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1204 : Room
{
public Room1204()
: base(1204, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 104, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 493, 113, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 54, 178, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 527, 190, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 45, 172, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 191, 268, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(241, 417, 46, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 532, 191, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 403, 291, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 459, 284, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 523, 188, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 198, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 62, 190, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 384, 266, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 127, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 128, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 258, 127, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 125, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 124, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(213, 489, 210, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 221, 216, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(32979, 365, 214, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 71, 218, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(212, 604, 212, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 141, 262, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 149, 243, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 318, 256, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 321, 242, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 541, 257, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 540, 238, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 460, 244, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 424, 207, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 208, 263, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 198, 279, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 165, 271, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 15, 254, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 623, 251, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 147, 283, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 647, 319, 0, 1204));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 652, 328, 0, 1204));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 4049;
                case RoomExit.South: return 1210;
                case RoomExit.East:  return 1205;
                case RoomExit.West:  return 1203;
                default: return 0;
            }
        }
}
}
