using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
    public class Room5043 : Room
    {
        public Room5043()
            : base(5043, "East Leinster Gatekeeper")
        { }
        public override void ApplyRoomLayout()
        {
            this.Background = RoomBackground.PlainDirt;
            this.BlockedRoomExits = BlockedExits.None;
            this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2501, 44, 58, 20, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2513, 262, 111, 70, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2602, 67, 206, 160, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(35370, 217, 138, 90, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2595, 247, 150, 20, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 158, 47, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(21, 380, 3, 65486, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(32782, 192, 210, 65516, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(14, 116, 228, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2526, 161, 53, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(32789, 548, 287, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(21, 656, 31, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(112, 382, 64, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2605, 140, 50, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(154, 626, 62, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2535, 714, 336, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2535, 717, 176, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2715, 564, 299, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2713, 612, 290, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(35485, 560, 321, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(49, 318, 14, 65386, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2586, 272, 148, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2724, 155, 207, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2582, 119, 156, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(2525, 144, 46, 0, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(32881, 313, 82, 65456, 5043));
            this.AddRoomDecoration(RoomDecoration.FromCode(154, 366, 7, 65456, 5043));
            // allow casting ? not for this room
            //this.AllowCasting = false;
            // First we build the npc face
            NPCFace face = new NPCFace(0, 0, 3, 0x0C, 1, 3, 0, 1, 0x0A, 0, 2, 5, 4);
            // then we build the body and set its location
            RealmOffline.NPC npc = RealmOffline.NPC.NPCFromCode(2197, 100, 100, "Blaustrom (NPC)",
                10000, 10000, this.RoomID, 0x9A, 0xC4, 2, face, this);
            // Now we add it to room
            this.Npcs.Add(npc);
            // 0, 0, 3, 12 1, 3, 0, 1, 10, 0, 2, 5, 4);
            base.ApplyRoomLayout();
        }
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 5028;
                case RoomExit.South: return 5058;
                case RoomExit.East: return 5044;
                case RoomExit.West: return 5042;
                default: return 0;
            }
        }
    }
}
