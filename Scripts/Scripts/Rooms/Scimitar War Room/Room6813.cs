using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6813 : Room
{
public Room6813()
: base(6813, "Scimitar War Room")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.UpDownLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 181, 358, 30, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2330, 37, 406, 300, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 465, 359, 30, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 105, 153, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 488, 153, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 183, 376, 259, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2312, 469, 376, 259, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2330, 322, 406, 300, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2330, 609, 407, 300, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2104, 95, 238, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65525, 167, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(35106, 641, 162, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 114, 150, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 240, 150, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 152, 153, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 400, 149, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 491, 149, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 367, 156, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(2310, 279, 155, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 533, 153, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65501, 191, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(14, 666, 189, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 271, 160, 0, 6813));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 381, 161, 0, 6813));


base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 6817;
                case RoomExit.West:  return 6802;
                default: return 0;
            }
        }
}
}
