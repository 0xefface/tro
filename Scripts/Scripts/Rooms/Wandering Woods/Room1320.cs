using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1320 : Room
{
public Room1320()
: base(1320, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65511, 124, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 461, 129, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 214, 128, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 147, 130, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 195, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 21, 217, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 628, 295, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 610, 296, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 259, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 101, 214, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 397, 256, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 143, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 10, 221, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(183, 54, 222, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 70, 215, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 132, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 132, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 131, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 145, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 307, 144, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 143, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 142, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 142, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 137, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 137, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 143, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(121, 244, 326, 0, 1320));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 461, 239, 0, 1320));



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
