using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room2908 : Room
{
public Room2908()
: base(2908, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 501, 158, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 580, 165, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 456, 188, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 546, 192, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 361, 182, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 197, 293, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 575, 195, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 390, 184, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 300, 312, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(51, 584, 277, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 490, 193, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1521, 407, 187, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 338, 319, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 374, 186, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 551, 196, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 641, 280, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 275, 301, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 406, 285, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 240, 288, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(180, 438, 284, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(123, 480, 192, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 658, 261, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1520, 691, 295, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 558, 167, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 451, 229, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 567, 185, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1594, 406, 161, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 352, 205, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 576, 231, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 41, 283, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 237, 196, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 231, 177, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 242, 163, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 306, 155, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 368, 154, 0, 2908));
this.AddRoomDecoration(RoomDecoration.FromCode(1595, 437, 155, 0, 2908));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 2903;
                case RoomExit.South: return 2913;
                case RoomExit.East:  return 2909;
                case RoomExit.West:  return 2907;
                default: return 0;
            }
        }
}
}
