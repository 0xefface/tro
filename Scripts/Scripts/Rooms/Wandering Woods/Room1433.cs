using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1433 : Room
{
public Room1433()
: base(1433, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 557, 127, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 99, 118, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 117, 192, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 187, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 106, 192, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 172, 110, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 127, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 127, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 131, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 524, 243, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 132, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 132, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 129, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 127, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 417, 126, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 131, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 127, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 571, 243, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 40, 114, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 136, 129, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32920, 572, 132, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 442, 126, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 220, 111, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 556, 238, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 65, 186, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 128, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(238, 337, 113, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32974, 367, 143, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(33007, 330, 217, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32988, 312, 251, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 412, 196, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 280, 194, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 302, 211, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 376, 192, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 322, 128, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 361, 151, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 300, 261, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 351, 259, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 281, 326, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 343, 329, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 386, 329, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 25, 293, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 51, 294, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 293, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 323, 120, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(32925, 65532, 149, 0, 1433));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 11, 137, 0, 1433));



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
