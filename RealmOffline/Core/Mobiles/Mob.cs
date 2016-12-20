using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Packets;

namespace RealmOffline.Core.Mobiles
{
    public class Mob : Mobile
    {
        public static bool IsValidID(short mobID)
        {
            return (mobID >= 2201 && mobID <= 2239
                || mobID >= 2248 && mobID <= 2322
                || mobID >= 2364 && mobID <= 2425
                || mobID >= 2427 && mobID <= 2432
                || mobID >= 2434 && mobID <= 2440
                || mobID >= 2476 && mobID <= 2508
                || mobID >= 2513 && mobID <= 2518);
        }
        public Brain MobBrain { get; set; }

        public override byte[] Serialize()
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


            w.WriteUShort(0x02);
            w.WriteUInt32(0x00);
            w.WriteShort(0x00);
            w.WriteByte(0x00);
            // now inventory
            // w.WriteUShort(0x00);
            // skin color ?
            //  w.WriteByte(0x00);
            //  w.WriteByte(0xFF);
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
        public override byte[] Serialize(out uint mobileID)
        {
            PacketWriter w = new PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            mobileID = ServerGlobals.GetNextAvailableID();
            this.GameID = mobileID;
            w.WriteUInt32(this.GameID);
            // Spells
            w.WriteUShort(0x00);
            w.WriteByte(0xFF);
            w.WriteBytes(new byte[] { 0x00, 0x0C, 0x08 });
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            w.WriteByte(0x01);
            w.WriteShort(0x00);
            // 3 more bytes here
            w.WriteBytes(new byte[3]);
            w.WriteInt32(this.CurrentHitPoints);
            w.WriteInt32(this.MaxHitPoints);
            // w.WriteBytes(new byte[3]); not here
            if (this.Location.CurrentRoom.RoomID > 65534)
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
            w.WriteUShort(this.Location.Facing); // always south
                                                 // now inventory
                                                 // w.WriteUShort(0x00);
                                                 // skin color ?
                                                 //w.WriteByte(0x00);
                                                 // w.WriteBytes(new byte[7]);
                                                 // w.WriteByte(0xFF);
            w.WriteUShort(0x02);
            w.WriteUInt32(0x00);
            w.WriteShort(0x00);
            w.WriteByte(0x00);
            return w.GetRawPacket();
        }
       
    }
}
