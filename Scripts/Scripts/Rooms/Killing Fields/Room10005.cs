using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10005 : Room
{
public Room10005()
: base(10005, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 620, 114, 65516, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 636, 335, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 65530, 251, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(151, 72, 117, 65516, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(150, 265, 117, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 489, 129, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 47, 220, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 574, 350, 20, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 200, 117, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 521, 148, 20, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 224, 237, 20, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 96, 137, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 270, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 64, 142, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 355, 238, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 418, 194, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 228, 120, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 571, 131, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 110, 134, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 65524, 265, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 458, 129, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 86, 76, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 585, 114, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 38, 285, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(32950, 154, 122, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 171, 117, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 518, 288, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 333, 102, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 123, 121, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 507, 131, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(44, 317, 205, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 450, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 462, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 474, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 485, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 497, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 509, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 521, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 533, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 545, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 556, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 568, 126, 0, 10005));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 39, 221, 0, 10005));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10013;
                case RoomExit.East:  return 10006;
                case RoomExit.West:  return 10004;
                default: return 0;
            }
        }
}
}
