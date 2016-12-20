using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
    public class Room4001 : Room
    {
        public Room4001()
            : base(4001, "South Havenwood")
        { }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.GrassyBlueSky;
            this.BlockedRoomExits = BlockedExits.None;
            this.AddRoomDecoration(RoomDecoration.FromCode(127, 149, 327, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(112, 245, 108, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(45, 464, 206, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(114, 466, 209, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(2536, 130, 105, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(2536, 559, 104, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(2536, 167, 106, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(32924, 31, 115, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(153, 92, 120, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(153, 538, 116, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(152, 592, 124, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(231, 264, 213, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(32999, 87, 212, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(32999, 446, 211, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(194, 621, 84, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(195, 18, 45, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(154, 210, 110, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(197, 103, 48, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(231, 628, 210, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 78, 119, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 101, 119, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 123, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 124, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 124, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 124, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(2539, 326, 106, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(2536, 528, 104, 0, 4001));
            this.AddRoomDecoration(RoomDecoration.FromCode(194, 323, 102, 0, 4001));



            base.ApplyRoomLayout();
        }
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5076;
                case RoomExit.South: return 4016;
                case RoomExit.East: return 4002;
                case RoomExit.West: return 4000;
                default: return 0;
            }
        }
    }
}
