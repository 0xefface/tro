using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1502 : Room
{
public Room1502()
: base(1502, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 363, 127, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 2, 117, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 530, 123, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 398, 127, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 226, 131, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 537, 125, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 50, 118, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 402, 255, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 109, 196, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 502, 248, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 434, 242, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 331, 208, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 585, 255, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 113, 105, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 218, 130, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 551, 252, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(32986, 354, 65531, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 124, 113, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 71, 141, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 45, 135, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 38, 144, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 305, 252, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 277, 237, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 376, 264, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 459, 255, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 517, 249, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 139, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 139, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 139, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(2711, 193, 130, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 127, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 105, 198, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 461, 123, 0, 1502));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 431, 256, 0, 1502));



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
