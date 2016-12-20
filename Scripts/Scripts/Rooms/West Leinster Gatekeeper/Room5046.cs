using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
    public class Room5046 : Room
    {
        public Room5046()
            : base(5046, "West Leinster Gatekeeper")
        { }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.PlainDirt;
            this.BlockedRoomExits = BlockedExits.None;
            this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2513, 255, 117, 70, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(35370, 209, 266, 200, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(7903, 113, 220, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2711, 70, 223, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(35479, 12, 224, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2724, 153, 212, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2748, 515, 13, 65437, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(35516, 351, 32, 65456, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2717, 49, 240, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2717, 562, 131, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2714, 581, 106, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2715, 553, 105, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2711, 628, 132, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2588, 16, 218, 40, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2713, 621, 23, 65456, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2594, 32, 215, 65, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2582, 117, 176, 15, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(3, 106, 225, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(3, 8, 229, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 143, 268, 200, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 150, 54, 0, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2526, 38, 208, 149, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 66, 228, 160, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2712, 280, 11, 65456, 5046));
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 49, 53, 0, 5046));

            RealmOffline.Core.Items.Base.Door d = RealmOffline.Core.Items.Base.Door.FromCode(729,
                this.RoomID, 260, 210, 5043, 260, 210, this);
            d.LockDoor(null);
            this.AddItem(d);
            base.ApplyRoomLayout();
        }
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5031;
                case RoomExit.South: return 5061;
                case RoomExit.East: return 5047;
                case RoomExit.West: return 5045;
                default: return 0;
            }
        }
    }
}
