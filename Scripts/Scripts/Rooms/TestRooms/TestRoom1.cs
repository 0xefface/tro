using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Scripts.Rooms.TestRooms
{
    public class TestRoom1 : Room
    {
        public TestRoom1()
            : base(15000009, "First Scripted Room")
        {
        }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.BrightSnowyPatchyGrass;
            //var cart = new MerchantCart085();
            //cart.SetLocation(this.RoomID, 443, 282, 0);
            //this.AddRoomDecoration(cart);
            //this.RandomizeTrees(20);
           // this.AddRoomDecoration(RoomDecoration.FromCode(85, 443, 282, 0, this.RoomID));
            this.BlockedRoomExits = BlockedExits.All;
            base.ApplyRoomLayout();
        }
        public void RandomizeTrees(ushort number)
        {
        }
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North:
                    return 1100;
                case RoomExit.South:
                    return 1101;
                case RoomExit.East:
                    return 1102;
                case RoomExit.West:
                    return 1102;
                default:
                    return 0;
            }
        }
    }
}
