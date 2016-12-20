using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6800 : Room
{
public Room6800()
: base(6800, "The Scimitar Tavern")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.UpDownLeft;
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2105, 371, 182, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 313, 173, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 462, 194, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 169, 156, 170, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 92, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 175, 275, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65505, 28, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 97, 139, 60, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 19, 155, 60, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 544, 183, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 313, 157, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 525, 199, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 544, 161, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 443, 85, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(7906, 173, 171, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65530, 202, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2338, 15, 21, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 564, 67, 65506, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 564, 121, 65496, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2123, 574, 129, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2126, 568, 125, 30, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2122, 559, 68, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 360, 101, 65526, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 338, 103, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2359, 181, 99, 65526, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2594, 160, 101, 0, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 188, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 289, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 398, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 495, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(2340, 591, 3, 65386, 6800));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 148, 162, 0, 6800));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 6802;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
