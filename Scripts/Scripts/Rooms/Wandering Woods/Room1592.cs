using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1592 : Room
{
public Room1592()
: base(1592, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 549, 126, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 260, 129, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 508, 142, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 604, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 45, 179, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 288, 139, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 383, 131, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 477, 146, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 75, 130, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 217, 200, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 197, 210, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 5, 196, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(35720, 536, 259, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 284, 200, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 203, 210, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 71, 236, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 325, 107, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 90, 124, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 264, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 429, 220, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 575, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 255, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 90, 240, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 546, 143, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 260, 201, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 215, 208, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 504, 252, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 139, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 138, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 364, 131, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 131, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 131, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 146, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 141, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 142, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 32, 315, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 17, 303, 0, 1592));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 627, 270, 0, 1592));



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
