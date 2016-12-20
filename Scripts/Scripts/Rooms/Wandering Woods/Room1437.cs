using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1437 : Room
{
public Room1437()
: base(1437, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(32945, 409, 104, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 516, 123, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 281, 218, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 78, 276, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 55, 277, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 269, 225, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 279, 227, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 519, 111, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(2742, 101, 108, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(240, 156, 31, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 275, 230, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 124, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 126, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 125, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 124, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 124, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 124, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 123, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 123, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(33701, 622, 212, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(33714, 497, 324, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(33711, 562, 255, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 648, 255, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(951, 718, 195, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 630, 215, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(957, 609, 310, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(959, 597, 270, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(13, 532, 200, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 425, 310, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 441, 299, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 462, 291, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 481, 281, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 494, 274, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 481, 256, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 480, 239, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 492, 225, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 514, 218, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 528, 206, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 551, 201, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 572, 194, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 593, 188, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 610, 185, 0, 1437));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 179, 0, 1437));


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
