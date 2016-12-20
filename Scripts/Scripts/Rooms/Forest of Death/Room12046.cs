using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12046 : Room
{
public Room12046()
: base(12046, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 352, 127, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 118, 125, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 307, 131, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 52, 129, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 574, 135, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 410, 132, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 362, 133, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 484, 134, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 113, 129, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 234, 132, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 168, 130, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 134, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 602, 257, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 520, 222, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 178, 284, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 155, 283, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 293, 246, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 39, 208, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 435, 214, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 204, 241, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 94, 323, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 327, 349, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 535, 320, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 21, 275, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 216, 257, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 304, 261, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 193, 237, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 266, 251, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 448, 224, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 530, 231, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 619, 272, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 597, 253, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 521, 221, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 442, 212, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 52, 216, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 236, 234, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 180, 281, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 405, 232, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 477, 218, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 419, 297, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 66, 229, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 534, 261, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 310, 290, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 442, 249, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 128, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 128, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 128, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 129, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 128, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 255, 131, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 130, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 133, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 133, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 130, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 131, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 134, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 134, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 135, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 136, 0, 12046));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 133, 0, 12046));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12041;
                case RoomExit.South: return 3101;
                case RoomExit.East:  return 12047;
                case RoomExit.West:  return 12045;
                default: return 0;
            }
        }
}
}
