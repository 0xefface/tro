using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1223 : Room
{
public Room1223()
: base(1223, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65464, 104, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 304, 106, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 299, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 71, 276, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 112, 275, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 62, 303, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 100, 297, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 127, 310, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 115, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 121, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 423, 112, 0, 1223));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 173, 283, 0, 1223));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1217;
                case RoomExit.South: return 1229;
                case RoomExit.East:  return 4121;
                case RoomExit.West:  return 1222;
                default: return 0;
            }
        }
}
}
