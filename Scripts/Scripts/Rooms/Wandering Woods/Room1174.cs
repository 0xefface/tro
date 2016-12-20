using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1174 : Room
{
public Room1174()
: base(1174, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 127, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 290, 131, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 155, 141, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 248, 138, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 298, 139, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 85, 136, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 44, 243, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 451, 242, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 633, 261, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 397, 248, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 90, 215, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 48, 308, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 391, 250, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(24, 555, 214, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 628, 259, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 198, 139, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 140, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 144, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 144, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 141, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 149, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 98, 306, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(32880, 78, 314, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 598, 270, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 224, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 450, 243, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 91, 211, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 141, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 138, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 137, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 144, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 139, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 140, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 140, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 137, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 137, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 137, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 281, 138, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 300, 138, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 1174));
this.AddRoomDecoration(RoomDecoration.FromCode(25, 576, 267, 0, 1174));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 1168;
                case RoomExit.South: return 1180;
                case RoomExit.East:  return 1175;
                case RoomExit.West:  return 1124;
                default: return 0;
            }
        }
}
}
