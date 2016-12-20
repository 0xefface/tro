using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3151 : Room
{
public Room3151()
: base(3151, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 132, 104, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 116, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 185, 109, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 346, 105, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 521, 239, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 237, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 118, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 120, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 583, 105, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32944, 98, 104, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 543, 236, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 74, 122, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 3, 321, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 122, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 121, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 122, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 122, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 123, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 124, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 578, 166, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 471, 167, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 350, 180, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 337, 172, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 280, 195, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 256, 235, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 287, 233, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 294, 185, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 316, 138, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 325, 113, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 331, 105, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 331, 131, 0, 3151));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 310, 170, 0, 3151));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12148;
                case RoomExit.South: return 3154;
                case RoomExit.East:  return 3152;
                case RoomExit.West:  return 3150;
                default: return 0;
            }
        }
}
}
