using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1445 : Room
{
public Room1445()
: base(1445, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(48, 395, 259, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 431, 283, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 389, 265, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(184, 408, 284, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 407, 292, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(950, 211, 180, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33722, 86, 124, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33705, 58, 180, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33707, 508, 239, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33713, 531, 325, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(949, 347, 183, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 639, 253, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 634, 178, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 509, 103, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 303, 102, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 65532, 179, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(953, 35, 102, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 591, 302, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(960, 570, 204, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 507, 149, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33725, 39, 135, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 278, 157, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33727, 363, 148, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(33726, 541, 158, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 81, 133, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7901, 540, 319, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 191, 102, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 109, 186, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 218, 194, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 332, 201, 0, 1445));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 448, 203, 0, 1445));



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
