using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3161 : Room
{
public Room3161()
: base(3161, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 103, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 181, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 65, 132, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 600, 129, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 149, 132, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 413, 231, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 317, 223, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 336, 239, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 356, 227, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 412, 231, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 448, 254, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 389, 255, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 368, 245, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 224, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 442, 243, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 350, 250, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 539, 132, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 375, 238, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 354, 235, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 401, 250, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 130, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 237, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 122, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 131, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 130, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 130, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 128, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 602, 129, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 128, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 344, 103, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 338, 121, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 314, 164, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 304, 162, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 224, 181, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 134, 183, 0, 3161));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 90, 185, 0, 3161));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3157;
                case RoomExit.South: return 3167;
                case RoomExit.East:  return 3162;
                case RoomExit.West:  return 3167;
                default: return 0;
            }
        }
}
}
