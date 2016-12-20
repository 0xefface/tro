using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10000 : Room
{
public Room10000()
: base(10000, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 103, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(32875, 44, 295, 65516, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 614, 236, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 77, 201, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(151, 70, 129, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 241, 125, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 153, 118, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 21, 202, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 442, 238, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 210, 123, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 614, 268, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 126, 104, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 91, 216, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 308, 270, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 215, 121, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 82, 137, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 52, 144, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 501, 111, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 346, 272, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 64, 206, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 518, 200, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 66, 227, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 554, 221, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 284, 303, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 268, 107, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 482, 107, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 225, 128, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 427, 224, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 631, 246, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 356, 111, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 504, 102, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 364, 104, 24, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 124, 106, 24, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 76, 206, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 260, 105, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 478, 104, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 151, 121, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 168, 121, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 186, 121, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 203, 121, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 221, 120, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 239, 122, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 261, 120, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(2, 278, 119, 0, 10000));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 65470, 322, 0, 10000));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10008;
                case RoomExit.East:  return 10001;
                case RoomExit.West:  return 2904;
                default: return 0;
            }
        }
}
}
