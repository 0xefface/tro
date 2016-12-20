using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items.Base
{
    public class Container : BaseGameItem
    {

        public override byte[] Serialize(out uint itemid)
        {
                itemid = ServerGlobals.GetNextAvailableID();
                this.GameID = itemid;
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteShort(0x73); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of naem
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            if (this.Enchantments.Count == 0)
            {
                w.WriteShort(0x00);
                w.WriteByte(0x00);
            }
            else
            {
                int totalenchants = this.Enchantments.Count;
                // must be 2 0x00 and 1 buff, if the item only has 1 buff.
                if (totalenchants == 1)
                {
                    w.WriteShort(0x00);
                    w.WriteByte(this.Enchantments[0]);
                }
                else if (totalenchants == 2)
                {
                    w.WriteByte(0x00);
                    w.WriteByte(this.Enchantments[0]);
                    w.WriteByte(this.Enchantments[1]);
                }
                else
                {
                    foreach (byte b in this.Enchantments)
                    {
                        w.WriteByte(b);
                    }
                }
            }
            w.WriteByte(0xFF);
            w.WriteByte(0x00);
            if (this.Location == null) { w.WriteByte(0x00); } // 0x01 if in a room with loc
            else
            {
                // Add room location
                if (this.Location.RoomNumber < 65534)
                {
                    w.WriteByte(0x01);
                    w.WriteUShort((ushort)this.Location.RoomNumber);
                }
                else
                {
                    w.WriteByte(0x02);
                    w.WriteUInt32(this.Location.RoomNumber);
                }
                w.WriteUShort(this.Location.X);
                w.WriteUShort(this.Location.Y);
                w.WriteUShort(this.Location.Facing);
            }
            w.WriteByte(0x01); // Not sure most items have this
            w.WriteByte((byte)(this.Equipped ? 1:0));
            // Not sure on all this
            w.WriteByte(0x00); // dunno
            w.WriteShort((short)this.ContainedItems.Count);


            w.WriteByte(0x00);
           // w.WriteUShort(0x00);
            w.WriteUInt32(0x00);
           // w.WriteBytes(new byte[3]);
            //w.WriteByte(0x00); // items in backpack just after this ?
            return w.GetRawPacket();
        }
        public static Container CastFromBaseGameItem(BaseGameItem item)
        {
            Container c = new Container();
            c.ContainedItems = item.ContainedItems;
            c.Enchantments = item.Enchantments;
            c.Equipped = item.Equipped;
            c.GameID = item.GameID;
            c.GraphicID = item.GraphicID;
            c.IsContainer = true;
            c.Color = item.Color;
            c.Name = item.Name;
            c.Location = item.Location;
            c.LookAt = item.LookAt;
            c.SqlID = item.SqlID;
            c.Type = item.Type;
            return c;
        }
        public override byte[] Serialize()
        {
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of name
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            if (this.Enchantments.Count == 0)
            {
                w.WriteShort(0x00);
                w.WriteByte(0x00);
            }
            else
            {
                int totalenchants = this.Enchantments.Count;
                // must be 2 0x00 and 1 buff, if the item only has 1 buff.
                if (totalenchants == 1)
                {
                    w.WriteShort(0x00);
                    w.WriteByte(this.Enchantments[0]);
                }
                else if (totalenchants == 2)
                {
                    w.WriteByte(0x00);
                    w.WriteByte(this.Enchantments[0]);
                    w.WriteByte(this.Enchantments[1]);
                }
                else
                {
                    foreach (byte b in this.Enchantments)
                    {
                        w.WriteByte(b);
                    }
                }

            }
            w.WriteByte(0xFF);
            w.WriteByte(0x00);
            if (this.Location == null) { w.WriteByte(0x00); } // 0x01 if in a room with loc
            else
            {
                // Add room location
                if (this.Location.RoomNumber < 65534)
                {
                    w.WriteByte(0x01);
                    w.WriteUShort((ushort)this.Location.RoomNumber);
                }
                else
                {
                    w.WriteByte(0x02);
                    w.WriteUInt32(this.Location.RoomNumber);
                }
                w.WriteUShort(this.Location.X);
                w.WriteUShort(this.Location.Y);
                w.WriteUShort(this.Location.Facing);
            }
            w.WriteByte(0x01); // Not sure most items have this
            w.WriteByte((byte)(this.Equipped ? 1:0));
            // Not sure on all this
            w.WriteByte(0x00); // dunno
            w.WriteShort((short)this.ContainedItems.Count);


            w.WriteByte(0x00);
            // w.WriteUShort(0x00);
            w.WriteUInt32(0x00);
         //   w.WriteBytes(new byte[3]);
            //w.WriteByte(0x00); // items in backpack just after this ?
            return w.GetRawPacket();
        }
    }
}
