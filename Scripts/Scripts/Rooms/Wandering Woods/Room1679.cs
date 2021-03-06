using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1679 : Room
{
public Room1679()
: base(1679, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 21, 123, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 496, 126, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 295, 130, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 466, 140, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 524, 149, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 576, 139, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 290, 133, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 363, 137, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 626, 149, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 232, 258, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 45, 212, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 80, 201, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 61, 210, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 148, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 298, 252, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 164, 257, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 238, 265, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 350, 259, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 357, 320, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 538, 321, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 139, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 140, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 137, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 133, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 133, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 137, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 136, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 136, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 140, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 139, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 139, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 151, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 151, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 151, 0, 1679));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 644, 318, 0, 1679));



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
