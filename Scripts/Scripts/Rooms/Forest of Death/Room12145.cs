using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12145 : Room
{
public Room12145()
: base(12145, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65511, 124, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 461, 129, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 214, 128, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 147, 130, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 195, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 21, 217, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 447, 238, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 256, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 259, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 101, 214, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 313, 254, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 587, 262, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32868, 592, 343, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 361, 325, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 129, 344, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 54, 222, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 70, 215, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 132, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 132, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 131, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 145, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 144, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 143, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 142, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 142, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 137, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 137, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 143, 0, 12145));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 143, 0, 12145));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12140;
                case RoomExit.South: return 3105;
                case RoomExit.East:  return 12146;
                case RoomExit.West:  return 12049;
                default: return 0;
            }
        }
}
}
