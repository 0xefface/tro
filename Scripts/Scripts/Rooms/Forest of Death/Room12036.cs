using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12036 : Room
{
public Room12036()
: base(12036, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 138, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 150, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 201, 127, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 281, 140, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 622, 256, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 421, 218, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 316, 266, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 294, 323, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 205, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 240, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 31, 211, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 172, 283, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 104, 290, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 183, 292, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32992, 91, 328, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 137, 299, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 392, 343, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 504, 313, 65516, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 284, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 52, 216, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 84, 215, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 319, 262, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 366, 255, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 344, 239, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 301, 245, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 0, 156, 74, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 620, 266, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 620, 256, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 286, 240, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 16, 280, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 411, 227, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 104, 294, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(32953, 171, 305, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 141, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 286, 140, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 140, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 140, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 137, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 144, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 144, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 151, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 151, 0, 12036));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 142, 0, 12036));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12031;
                case RoomExit.South: return 12041;
                case RoomExit.East:  return 12037;
                case RoomExit.West:  return 12035;
                default: return 0;
            }
        }
}
}
