using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1450 : Room
{
public Room1450()
: base(1450, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 95, 136, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 28, 257, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 604, 322, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 127, 123, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 81, 266, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 91, 217, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 217, 220, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 436, 243, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 273, 142, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 526, 257, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 460, 256, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 344, 246, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 359, 266, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 434, 239, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 235, 231, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 109, 227, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 79, 215, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 6, 269, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 19, 254, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 236, 225, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 485, 254, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 338, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 540, 268, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 529, 254, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 113, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 339, 117, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 532, 133, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 136, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 135, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 133, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 141, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 141, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 139, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 330, 140, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 145, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 145, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 150, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 151, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 141, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 130, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 131, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 137, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 147, 117, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 139, 146, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 142, 128, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 136, 171, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 149, 224, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 176, 226, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 147, 173, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 149, 149, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(135, 299, 238, 0, 1450));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 652, 312, 0, 1450));



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
