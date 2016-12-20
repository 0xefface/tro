using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1215 : Room
{
public Room1215()
: base(1215, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 178, 108, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 574, 309, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 564, 318, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 139, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 104, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 328, 1, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 255, 106, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 37, 121, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 84, 110, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 19, 138, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(229, 63, 171, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 162, 182, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(227, 176, 174, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 332, 245, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 290, 200, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 299, 193, 0, 1215));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 351, 226, 0, 1215));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1209;
                case RoomExit.South: return 1221;
                case RoomExit.East:  return 1216;
                case RoomExit.West:  return 1214;
                default: return 0;
            }
        }
}
}
