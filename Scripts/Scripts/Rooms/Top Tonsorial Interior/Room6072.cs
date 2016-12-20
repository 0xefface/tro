using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6072 : Room
{
public Room6072()
: base(6072, "Top Tonsorial Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 296, 80, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 95, 79, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 585, 116, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 200, 75, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 394, 79, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2018, 33, 128, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 499, 74, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 479, 190, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 578, 190, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 513, 225, 50, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2558, 612, 224, 50, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 19, 215, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2556, 30, 248, 50, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(2102, 557, 298, 0, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(34914, 627, 305, 50, 6072));
this.AddRoomDecoration(RoomDecoration.FromCode(34910, 598, 301, 50, 6072));



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
