using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12146 : Room
{
public Room12146()
: base(12146, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 143, 114, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 553, 126, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 383, 121, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 453, 139, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 605, 158, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 197, 138, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 255, 123, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 327, 140, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 146, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 53, 129, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 153, 128, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 39, 210, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 247, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 94, 185, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 629, 267, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 88, 205, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 6, 270, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 527, 340, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 300, 331, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 75, 309, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(100, 123, 350, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(1222, 364, 257, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(32990, 430, 223, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(222, 60, 214, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 137, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 196, 137, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 137, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 126, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 126, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 301, 139, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 122, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 145, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 145, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 138, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 144, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 144, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 157, 0, 12146));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 157, 0, 12146));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12141;
                case RoomExit.South: return 3106;
                case RoomExit.East:  return 12147;
                case RoomExit.West:  return 12145;
                default: return 0;
            }
        }
}
}
