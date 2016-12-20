using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6011 : Room
{
public Room6011()
: base(6011, "Expeditionary Provisions Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 514, 9, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 120, 9, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2018, 35, 59, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 308, 47, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 224, 4, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 416, 5, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2006, 603, 66, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 136, 340, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 173, 235, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 447, 298, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2042, 478, 165, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2554, 531, 175, 20, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 377, 158, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 79, 175, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2041, 65534, 187, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 279, 158, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2043, 189, 157, 0, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 90, 180, 20, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 411, 192, 50, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2553, 9, 190, 20, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 313, 192, 50, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2555, 223, 191, 50, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2136, 387, 305, 50, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2123, 182, 244, 70, 6011));
this.AddRoomDecoration(RoomDecoration.FromCode(2122, 135, 340, 50, 6011));



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
