using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10003 : Room
{
public Room10003()
: base(10003, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Up;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 620, 114, 65516, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 585, 249, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 232, 218, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(151, 72, 117, 65516, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(150, 272, 119, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(149, 489, 129, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 1, 319, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 187, 232, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 328, 120, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 121, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 68, 137, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 331, 123, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 570, 266, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 360, 129, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 92, 123, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 232, 236, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 36, 116, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 552, 124, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 124, 201, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 93, 330, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 160, 125, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 44, 280, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 559, 126, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 579, 311, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 110, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(32954, 366, 303, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 325, 100, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 72, 118, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 589, 257, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 447, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 459, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 467, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 479, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 488, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 500, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 512, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(1, 523, 122, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 128, 0, 10003));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 128, 0, 10003));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 10011;
                case RoomExit.East:  return 10004;
                case RoomExit.West:  return 10002;
                default: return 0;
            }
        }
}
}
