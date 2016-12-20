using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room12016 : Room
{
public Room12016()
: base(12016, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 302, 131, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 503, 142, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 136, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 282, 135, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 145, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 459, 135, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 35, 205, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 288, 245, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 575, 254, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 513, 327, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 77, 186, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 144, 245, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 95, 186, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 344, 235, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 337, 106, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 447, 230, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 474, 222, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 422, 215, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(185, 142, 270, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 232, 261, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 551, 332, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 136, 236, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 40, 205, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 63, 205, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 32, 199, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 87, 196, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 573, 263, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 602, 266, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 610, 318, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 580, 328, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 636, 333, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(62, 50, 196, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(32830, 211, 241, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 287, 300, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 254, 307, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 441, 357, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 540, 307, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 273, 280, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(32993, 224, 299, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 301, 271, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 248, 288, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(233, 318, 174, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(33001, 335, 130, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 140, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 198, 133, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 133, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 139, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 254, 133, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 133, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 134, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 144, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 144, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 144, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 133, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 141, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 140, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 140, 0, 12016));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 141, 0, 12016));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 12011;
                case RoomExit.South: return 12021;
                case RoomExit.East:  return 12017;
                case RoomExit.West:  return 12015;
                default: return 0;
            }
        }
}
}
