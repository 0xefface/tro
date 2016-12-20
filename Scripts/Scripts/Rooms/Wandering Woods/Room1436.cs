using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1436 : Room
{
public Room1436()
: base(1436, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 119, 135, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(165, 275, 115, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 35, 321, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 234, 303, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 576, 417, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 197, 303, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(47, 11, 341, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 294, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 170, 142, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 365, 145, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 464, 144, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 364, 146, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 347, 141, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 369, 140, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 140, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 487, 145, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7, 457, 146, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 129, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 129, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 144, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 144, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 144, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 133, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 145, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 131, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 132, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 131, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(113, 226, 304, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 117, 134, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 66, 221, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65521, 328, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 118, 141, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 123, 107, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 81, 120, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 108, 37, 0, 1436));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 37, 319, 0, 1436));



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
