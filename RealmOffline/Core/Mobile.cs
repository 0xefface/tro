using RealmOffline.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public class Mobile : Entity, IComparable<Mobile>
    {
        public override string Name { get; set; }
        public override ushort GraphicID { get; set; }
        public override uint GameID { get; set; }
        public byte Girth { get; set; }
        public byte Height { get; set; }
        public byte Gender { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public override ushort Color { get; set; }
        public int CompareTo(Mobile mobile)
        {
            if (this.Name == mobile.Name && this.GraphicID == mobile.GraphicID) { return 1; }
            else return 0;
        }
        public override byte[] Serialize(out uint itemID)
        {
            itemID = 0;
            return new byte[0];
        }
        public virtual byte[] Serialize()
        {
            return new byte[0];
        }
        public override void Deserialize(byte[] data)
        {
            
        }
        public virtual byte[] AppearInRoom()
        {

            PacketWriter w = new PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            // Spells
            w.WriteShort(0x00);
            w.WriteByte(0xFF);
            w.WriteBytes(new byte[] { 0x00, 0x0C, 0x08 });
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            w.WriteByte(0x01); // class/ race, it dont matter
            w.WriteByte(0x00); // n
            w.WriteByte(0x00); // n
            // End
            w.WriteByte(0x00); // crash not valid selector for player
            w.WriteByte(0x00); // crash not valid
            w.WriteByte(0x00); // 1 here is no fight
            w.WriteInt32(this.CurrentHitPoints);
            w.WriteInt32(this.MaxHitPoints);

            if (this.Location.CurrentRoom.RoomID < 65534)
            {
                w.WriteByte(0x01);
                w.WriteShort((short)this.Location.CurrentRoom.RoomID);
            }
            else
            {
                w.WriteByte(0x02);
                w.WriteUInt32(this.Location.CurrentRoom.RoomID);
            }
            w.WriteUShort(this.Location.X);
            w.WriteUShort(this.Location.Y);
            w.WriteUShort(this.Location.Facing);

            // now inventory
            w.WriteUShort(0x00);
            // skin color ?
            w.WriteByte(0x00);
            w.WriteBytes(new byte[7]);
            w.WriteByte(0xFF);
            /*
            w.WriteByte(0x00); // 14 on fufu
            w.WriteByte(0x00); // crash
            w.WriteByte(0x00); //nada
            w.WriteByte(0x00); // allows talk
            w.WriteByte(0x00); // talk 
            w.WriteByte(0x00); // mob wont show 
            w.WriteByte(0x00); // mob wont show 
            w.WriteByte(0x00); 
            w.WriteByte(0xFF);
        */
            return w.GetRawPacket();

        }
    }
}
