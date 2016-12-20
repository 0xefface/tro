using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12031 : Room
{
public Room12031()
: base(12031, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 149, 141, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 309, 140, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 141, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 523, 142, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 114, 222, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 343, 247, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 309, 321, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 415, 239, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 217, 221, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 480, 237, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 385, 225, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 599, 260, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 63, 320, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 117, 223, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 600, 263, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 121, 337, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 146, 304, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 54, 291, 65516, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 151, 335, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 47, 308, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 65474, 339, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(131, 0, 156, 28, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 234, 229, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 96, 220, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 121, 220, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 211, 219, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 348, 262, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 337, 244, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 406, 237, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 475, 236, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 581, 274, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 133, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 140, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 140, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 124, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 273, 139, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 138, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 139, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 142, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 388, 141, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 141, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 139, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 143, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 142, 0, 12031));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 142, 0, 12031));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12026;
                case RoomExit.South: return 12036;
                case RoomExit.East:  return 12032;
                case RoomExit.West:  return 12030;
                default: return 0;
            }
        }
}
}
