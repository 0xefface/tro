using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1448 : Room
{
public Room1448()
: base(1448, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 480, 102, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 290, 103, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 105, 102, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 664, 130, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 362, 304, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 323, 284, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 288, 288, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 330, 291, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 344, 308, 6, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 45, 136, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 136, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 135, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 136, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 123, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 123, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 134, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 138, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 136, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 136, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 135, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 589, 132, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 132, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 132, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 208, 104, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 200, 130, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 203, 113, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 240, 153, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 247, 146, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 328, 163, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 353, 174, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 365, 163, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 463, 186, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 476, 180, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 601, 204, 0, 1448));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 655, 317, 0, 1448));



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
