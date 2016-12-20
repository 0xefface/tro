using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1655 : Room
{
public Room1655()
: base(1655, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(196, 123, 136, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 122, 137, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(210, 154, 128, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(247, 236, 47, 65461, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(33004, 276, 54, 65486, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(33006, 231, 64, 65486, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(21, 443, 104, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 334, 100, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7909, 153, 154, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(32994, 262, 129, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(226, 209, 116, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65531, 327, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(15, 253, 102, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 239, 138, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(163, 424, 132, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 533, 109, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(145, 225, 106, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 617, 141, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(155, 199, 113, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 224, 104, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 445, 104, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(46, 224, 116, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(32875, 152, 312, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 317, 319, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(125, 336, 104, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 490, 235, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 205, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 177, 113, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 521, 155, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 537, 154, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 547, 156, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 52, 337, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(2955, 597, 239, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(2956, 626, 206, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 64, 232, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 99, 34, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 100, 170, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 151, 98, 0, 1655));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 87, 131, 0, 1655));



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
