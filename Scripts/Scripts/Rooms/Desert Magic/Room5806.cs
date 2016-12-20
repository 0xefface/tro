using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
    public class Room5806 : Room
    {
        public Room5806()
            : base(5806, "Desert Magic")
        { }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.PlainDirt;
            this.BlockedRoomExits = BlockedExits.None;
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 51, 60, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2526, 148, 64, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 356, 56, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2526, 262, 65, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(1585, 120, 284, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2717, 320, 231, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2597, 319, 189, 15, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(34353, 522, 274, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(35723, 7, 212, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2955, 76, 219, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2631, 27, 85, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2633, 88, 88, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2634, 361, 86, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2633, 210, 88, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2633, 293, 86, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2597, 23, 189, 15, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2717, 151, 230, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2597, 120, 189, 15, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2708, 409, 80, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(60, 387, 227, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2585, 43, 176, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2585, 140, 176, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2585, 339, 176, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 16, 94, 19, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 133, 93, 19, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 238, 93, 19, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 352, 92, 19, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2802, 433, 132, 18, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2792, 449, 114, 65526, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(7901, 86, 233, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 290, 212, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 108, 210, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 407, 205, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 371, 199, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 182, 210, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 332, 211, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 24, 198, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 352, 213, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 144, 212, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 296, 212, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 402, 214, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32832, 90, 205, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32832, 154, 210, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(32832, 408, 196, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(1585, 126, 253, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(1587, 40, 245, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(2717, 380, 230, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(7901, 377, 230, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(3, 191, 219, 0, 5806));
            this.AddRoomDecoration(RoomDecoration.FromCode(3, 286, 219, 0, 5806));


            base.ApplyRoomLayout();
        }
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 21495;
                case RoomExit.South: return 5810;
                case RoomExit.East: return 21498;
                case RoomExit.West: return 5805;
                default: return 0;
            }
        }
    }
}
