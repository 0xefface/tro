using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6059 : Room
{
public Room6059()
: base(6059, "The Bloated Swine")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 76, 164, 50, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(3599, 492, 312, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 433, 15, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2005, 531, 116, 100, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 156, 230, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 373, 272, 170, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2128, 154, 302, 220, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2017, 44, 118, 100, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 267, 310, 200, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 467, 230, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 417, 234, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 364, 262, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 416, 292, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 536, 236, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 588, 243, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 586, 282, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 402, 192, 65516, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 398, 275, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 456, 262, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 501, 262, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(59529, 559, 276, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 240, 57, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 147, 14, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 339, 58, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2221, 626, 223, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 297, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2599, 121, 293, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2112, 154, 152, 50, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2126, 156, 231, 63, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2117, 365, 182, 80, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2006, 607, 118, 50, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2595, 10, 163, 0, 6059));
this.AddRoomDecoration(RoomDecoration.FromCode(2086, 65533, 189, 0, 6059));



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
