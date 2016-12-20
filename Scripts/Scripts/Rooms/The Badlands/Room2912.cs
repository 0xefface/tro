using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2912 : Room
{
public Room2912()
: base(2912, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(123, 119, 107, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 474, 109, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 493, 155, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 526, 118, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 128, 109, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 215, 183, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 244, 204, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 469, 156, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 483, 110, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 496, 118, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 503, 157, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 542, 122, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 258, 182, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1592, 114, 193, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1592, 120, 185, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1592, 120, 199, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1592, 159, 180, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 294, 154, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 306, 175, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 355, 138, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 362, 199, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 371, 155, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 378, 170, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 406, 189, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 418, 130, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 420, 143, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 422, 124, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 461, 106, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 472, 134, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 517, 146, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 522, 105, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 530, 133, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 582, 104, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 115, 107, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 197, 187, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 204, 196, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 450, 110, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 459, 155, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 601, 166, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 45, 284, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 140, 105, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 247, 186, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 270, 197, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 454, 113, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 483, 119, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 500, 153, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(32948, 530, 121, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(34360, 103, 188, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 20, 315, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(35724, 615, 315, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(12322, 316, 0, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(58089, 295, 0, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 226, 200, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 11, 180, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 187, 180, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 281, 201, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 376, 340, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 558, 161, 0, 2912));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2912));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2907;
                case RoomExit.South: return 2917;
                case RoomExit.East:  return 2913;
                case RoomExit.West:  return 2911;
                default: return 0;
            }
        }
}
}
