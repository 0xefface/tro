using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1439 : Room
{
public Room1439()
: base(1439, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 605, 324, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 452, 313, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 568, 320, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 235, 205, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 583, 159, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 639, 272, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 370, 311, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 703, 303, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 245, 104, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(35510, 479, 118, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 390, 205, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 595, 321, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 339, 311, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32978, 362, 206, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 610, 238, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 38, 243, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(33701, 65533, 224, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 62, 188, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(934, 154, 212, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 28, 220, 36, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(946, 224, 351, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 184, 204, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7907, 62, 196, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(110, 99, 222, 36, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 81, 189, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 84, 176, 10, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(211, 307, 207, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 21, 211, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 89, 187, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 319, 241, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(941, 173, 280, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(955, 111, 190, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(33723, 32, 191, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 528, 279, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 76, 208, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(958, 41, 238, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 121, 289, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(960, 67, 323, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(33728, 93, 220, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 267, 235, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 504, 218, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 499, 277, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 451, 218, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 542, 223, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 532, 215, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 416, 243, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 148, 209, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32790, 529, 299, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32789, 287, 271, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 571, 213, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 502, 205, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32791, 187, 179, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(23, 494, 275, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 620, 280, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(32872, 6, 185, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(35723, 187, 246, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(214, 456, 233, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 492, 276, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(104, 431, 215, 0, 1439));
this.AddRoomDecoration(RoomDecoration.FromCode(7900, 108, 523, 0, 1439));



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
