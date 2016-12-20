using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room6608 : Room
{
public Room6608()
: base(6608, "Take It or Leave It Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
this.AddRoomDecoration(RoomDecoration.FromCode(2008, 464, 15, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2016, 145, 5, 35, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 201, 5, 20, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2028, 401, 3, 20, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2029, 288, 47, 20, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 404, 108, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2166, 303, 91, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2081, 609, 135, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2082, 212, 108, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2131, 259, 166, 65519, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2164, 96, 92, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2101, 158, 280, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2103, 268, 282, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2109, 305, 163, 65516, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2127, 330, 164, 65521, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(34928, 305, 167, 18, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 618, 225, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 637, 261, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 595, 302, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2241, 169, 182, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2244, 115, 192, 0, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2596, 573, 135, 6, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 190, 112, 6, 6608));
this.AddRoomDecoration(RoomDecoration.FromCode(2597, 383, 112, 6, 6608));



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
