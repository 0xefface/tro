using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1420 : Room
{
public Room1420()
: base(1420, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.Left;
this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(196, 122, 136, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(190, 122, 137, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32881, 648, 316, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 279, 106, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32933, 523, 113, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 124, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 200, 320, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 46, 335, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 170, 192, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 192, 156, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 525, 231, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 317, 334, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(127, 509, 232, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 237, 111, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 165, 110, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 550, 125, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 187, 116, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(152, 360, 125, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 620, 115, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 312, 126, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 64, 226, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 124, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 124, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 124, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 162, 189, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 180, 200, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 505, 234, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 169, 197, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 499, 318, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 124, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 511, 227, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(176, 317, 103, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 123, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 111, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 119, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 225, 112, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 118, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 117, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 116, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 65521, 333, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 124, 137, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 131, 101, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7904, 85, 119, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7903, 118, 29, 0, 1420));
this.AddRoomDecoration(RoomDecoration.FromCode(7908, 34, 316, 0, 1420));



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
