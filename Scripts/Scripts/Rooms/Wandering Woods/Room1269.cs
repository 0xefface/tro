using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1269 : Room
{
public Room1269()
: base(1269, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 77, 124, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 137, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 628, 144, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 149, 133, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 300, 145, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 29, 258, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 310, 260, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 554, 317, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 313, 274, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 55, 258, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 581, 205, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 497, 313, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32795, 576, 153, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32813, 220, 224, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(202, 357, 259, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 405, 266, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 58, 266, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 220, 230, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 191, 228, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 417, 275, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 588, 215, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 139, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 139, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 131, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 129, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 338, 269, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 145, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 133, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 132, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 132, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 279, 145, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(32796, 117, 125, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 495, 241, 0, 1269));
this.AddRoomDecoration(RoomDecoration.FromCode(26, 90, 249, 0, 1269));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12;
                case RoomExit.South: return 12;
                case RoomExit.East:  return 12;
                case RoomExit.West:  return 12;
                default: return 0;
            }
        }
}
}
