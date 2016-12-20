using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1280 : Room
{
public Room1280()
: base(1280, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 97, 125, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 310, 128, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 532, 132, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 494, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 595, 143, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 124, 132, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 161, 129, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 355, 144, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 292, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 229, 133, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 310, 249, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 320, 251, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 413, 241, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 363, 238, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 386, 223, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 435, 220, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 603, 261, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 326, 235, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 320, 247, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 483, 229, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 424, 230, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 602, 253, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 379, 236, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 124, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 124, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 133, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 142, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 141, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 140, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 143, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 139, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 343, 236, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(195, 409, 100, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(197, 133, 103, 0, 1280));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 584, 257, 0, 1280));


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
