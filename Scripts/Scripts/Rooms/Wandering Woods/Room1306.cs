using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1306 : Room
{
public Room1306()
: base(1306, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65512, 127, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 454, 137, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 471, 141, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 84, 136, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 250, 140, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 369, 142, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 297, 147, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 520, 145, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 196, 139, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 117, 146, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 26, 210, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 218, 235, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 34, 235, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 360, 262, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 189, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 311, 249, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 432, 216, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 114, 177, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 574, 255, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 299, 267, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 169, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 168, 148, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 105, 190, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 189, 0, 49, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 189, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(189, 0, 49, 311, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 42, 166, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 66, 192, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 125, 179, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 279, 232, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 303, 255, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 265, 256, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 22, 234, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 137, 303, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 471, 229, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 582, 241, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 162, 148, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 148, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 145, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 136, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 141, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 146, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 143, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 142, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 142, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 141, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 139, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 145, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 144, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 129, 176, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(181, 663, 220, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 588, 262, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 642, 241, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 652, 222, 0, 1306));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65515, 219, 0, 1306));



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
