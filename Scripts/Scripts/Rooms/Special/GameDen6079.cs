using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Scripts.Rooms.Special
{
    public class GameDen6079: Room
    {
        public GameDen6079()
            : base(6079, "Game Den")
        {
        }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.PavedRoom1;
            this.BlockedRoomExits = BlockedExits.All;
            this.AllowCasting = true;
            this.AddRoomDecoration(RoomDecoration.FromCode(2338, 165, 63, 65436, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2339, 468, 61, 65436, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2340, 314, 46, 65436, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2340, 107, 64, 65436, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2338, 5, 114, 65486, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2340, 519, 64, 65436, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2340, 617, 114, 65486, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2389, 113, 66, 65476, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2389, 532, 71, 65486, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 118, 92, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 88, 100, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 521, 95, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 536, 94, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 109, 95, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 103, 90, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 118, 102, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 109, 120, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 110, 81, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 101, 82, 65516, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 529, 116, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 529, 105, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 523, 99, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 536, 97, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 529, 90, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 520, 93, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 537, 91, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 528, 80, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 105, 76, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 118, 77, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(63, 110, 67, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 524, 93, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 102, 113, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 505, 109, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 523, 103, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 105, 81, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 89, 74, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 519, 86, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 503, 95, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 504, 76, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 88, 112, 15, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(64, 518, 76, 10, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(32831, 98, 101, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2284, 110, 109, 65526, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2284, 528, 104, 65526, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(7900, 18, 182, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(7900, 606, 182, 0, 6079)); 
            this.AddRoomDecoration(RoomDecoration.FromCode(2252, 316, 174, 65516, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(32782, 164, 188, 0, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2252, 316, 203, 65516, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(2252, 316, 233, 65516, 6079));
            this.AddRoomDecoration(RoomDecoration.FromCode(14, 469, 188, 0, 6079));

            /*
             * 0xCC, 0x08, 0x3C, 0x01, 0x0A, 0x01, 0xEC, 0xFF, 
0x87, 0x0A, 0x87, 0x01, 0x56, 0x00, 0x00, 0x00, 
0x87, 0x8A, 0xF4, 0x00, 0x56, 0x00, 0x00, 0x00, 
0xDC, 0x1E, 0x3A, 0x01, 0xA5, 0x00, 0x00, 0x00, 
0x10, 0x00, 0x7B, 0x02, 0x54, 0x01, 0x00, 0x00, 
0x10, 0x80, 0x07, 0x00, 0x52, 0x01, 0x00, 0x00, 
0x03, 0x00, 0xA4, 0x00, 0xAB, 0x00, 0x00, 0x00, 
0x03, 0x00, 0xCD, 0x01, 0xAB, 0x00, 0x00, 0x00, 
0x03, 0x00, 0x97, 0x00, 0x38, 0x01, 0x00, 0x00, 
0x03, 0x00, 0xEA, 0x01, 0x3A, 0x01, 0x00, 0x00, 
0x03, 0x00, 0x97, 0x00, 0x20, 0x01, 0x00, 0x00, 
0x03, 0x00, 0x97, 0x00, 0x09, 0x01, 0x00, 0x00, 
0x03, 0x00, 0x8B, 0x00, 0xFF, 0x00, 0x00, 0x00, 
0x03, 0x00, 0xEA, 0x01, 0x25, 0x01, 0x00, 0x00, 
0x03, 0x00, 0xEA, 0x01, 0x0F, 0x01, 0x00, 0x00, 
0x03, 0x00, 0xF0, 0x01, 0x01, 0x01, 0x00, 0x00,  //67
             */
            base.ApplyRoomLayout();
        }
    }
}
