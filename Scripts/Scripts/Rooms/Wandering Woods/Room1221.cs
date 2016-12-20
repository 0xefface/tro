using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1221 : Room
{
public Room1221()
: base(1221, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 333, 103, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 561, 176, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 557, 194, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 321, 197, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 329, 196, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 268, 355, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 39, 312, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 228, 288, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 129, 304, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 133, 286, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 178, 213, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 198, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 140, 297, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 95, 292, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 325, 211, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 197, 305, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 228, 294, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(245, 296, 27, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 263, 104, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 261, 128, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 259, 107, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 295, 150, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 310, 149, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 357, 175, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 374, 168, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 416, 193, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 427, 190, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 422, 239, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 453, 241, 0, 1221));
this.AddRoomDecoration(RoomDecoration.FromCode(106, 107, 304, 0, 1221));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1215;
                case RoomExit.South: return 1227;
                case RoomExit.East:  return 1222;
                case RoomExit.West:  return 1220;
                default: return 0;
            }
        }
}
}
