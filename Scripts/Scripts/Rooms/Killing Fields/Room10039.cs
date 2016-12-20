using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room10039 : Room
{
public Room10039()
: base(10039, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.Right;
this.AddRoomDecoration(RoomDecoration.FromCode(32919, 533, 108, 65516, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 20, 132, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65424, 104, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(107, 597, 314, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 603, 208, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 623, 188, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 530, 111, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 54, 132, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(224, 575, 221, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 30, 126, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 417, 107, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 517, 122, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 474, 329, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 78, 264, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 116, 109, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 36, 186, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 8, 182, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 463, 112, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 379, 107, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 392, 294, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 225, 298, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(182, 98, 123, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 41, 186, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(186, 520, 109, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(94, 295, 105, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 65457, 106, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 57, 110, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(1110, 419, 111, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(111, 419, 113, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 424, 111, 12, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 376, 108, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(60, 595, 346, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 131, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 32, 131, 0, 10039));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 48, 131, 0, 10039));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 10031;
                case RoomExit.South: return 10047;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 10038;
                default: return 0;
            }
        }
}
}
