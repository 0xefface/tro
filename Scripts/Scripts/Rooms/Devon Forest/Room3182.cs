using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room3182 : Room
{
public Room3182()
: base(3182, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 432, 107, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32818, 629, 335, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 274, 355, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 50, 118, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 122, 127, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 531, 123, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 614, 117, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 581, 125, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 61, 273, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 32, 275, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 126, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 117, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 117, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 122, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 124, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 124, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 124, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 124, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(220, 299, 261, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(206, 306, 127, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(236, 276, 110, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32989, 305, 183, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(208, 309, 228, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 203, 275, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 185, 265, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 380, 184, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 390, 190, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32878, 395, 264, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 276, 120, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 182, 226, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 458, 227, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 27, 185, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 625, 227, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 293, 131, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 321, 205, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 299, 226, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 285, 276, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 309, 274, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(32996, 37, 199, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 268, 326, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 337, 326, 0, 3182));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 277, 117, 0, 3182));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 3175;
                case RoomExit.South: return 3189;
                case RoomExit.East:  return 3183;
                case RoomExit.West:  return 3181;
                default: return 0;
            }
        }
}
}
