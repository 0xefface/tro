using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10001 : Room
{
public Room10001()
: base(10001, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(151, 610, 109, 65516, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 141, 143, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 25, 117, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 509, 141, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 114, 108, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 103, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 613, 210, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 540, 110, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 612, 217, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 21, 132, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 484, 134, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 232, 322, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 341, 143, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 479, 121, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 547, 134, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 0, 152, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 522, 332, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 15, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 10, 133, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 85, 298, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 171, 280, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 71, 143, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 529, 132, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(32954, 571, 220, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 349, 116, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 391, 131, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(2715, 487, 116, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 41, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 53, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 64, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 78, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 91, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 103, 138, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 333, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 345, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 357, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 369, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 381, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 393, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 405, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 416, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 428, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 438, 126, 0, 10001));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 450, 126, 0, 10001));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10009;
                case RoomExit.East:  return 10002;
                case RoomExit.West:  return 10000;
                default: return 0;
            }
        }
}
}
