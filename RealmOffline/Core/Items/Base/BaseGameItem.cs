using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items.Base
{
    public abstract class BaseGameItem : Entity
    {
        private ushort graphicID;
        public override ushort GraphicID
        {
            get { return graphicID; }
            set { graphicID = value; }
        }
        private uint gameID;
        public override uint GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        private ushort color;
        public override ushort Color
        {
            get { return color; }
            set { color = value; }
        }
        private string itemName = "";
        public override string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private List<byte> enchantments;
        public List<byte> Enchantments
        {
            get
            {
                if (enchantments == null)
                    enchantments = new List<byte>();
                return enchantments;
            }
            set { enchantments = value; }
        }
        private RoomLocation location;
        public RoomLocation Location
        {
            get { return location; }
            set { location = value; }
        }
        private bool equipped;
        public bool Equipped
        {
            get { return equipped; }
            set { equipped = value; }
        }
        private bool isContainer;
        public bool IsContainer
        {
            get { return isContainer; }
            set { isContainer = value; }
        }
        private List<BaseGameItem> containedItems;
        public List<BaseGameItem> ContainedItems
        {
            get
            {
                if (containedItems == null)
                    containedItems = new List<BaseGameItem>();
                return containedItems;
            }
            set { containedItems = value; }
        }
        private int sqlID;
        public int SqlID
        {
            get { return sqlID; }
            set { sqlID = value; }
        }
        private int val;
        public int Value
        {
            get { return val; }
            set { val = value; }
        }
        private uint sqlOwnerID;
        public uint SqlOwnerID
        {
            get { return sqlOwnerID; }
            set { sqlOwnerID = value; }
        }
        private ItemType type;
        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }
        private string lookAt;
        public string LookAt
        {
            get { return lookAt; }
            set { lookAt = value; }
        }
        private bool isInventoryItem;
        public bool IsInventoryItem
        {
            get { return isInventoryItem; }
            set { isInventoryItem = value; }
        }
        private EquipmentSlot equipableSlot = EquipmentSlot.None;
        public EquipmentSlot EquipableSlot
        {
            get { return equipableSlot; }
            set { equipableSlot = value; }
        }
        private short armorFactor;
        public short ArmorFactor
        {
            get { return armorFactor; }
            set { armorFactor = value; }
        }
        private short durability;
        public short Durability
        {
            get { return durability; }
            set { durability = value; }
        }
        private short minimumDamage;
        public short MinimumDamage
        {
            get { return minimumDamage; }
            set { minimumDamage = value; }
        }
        private short maximumDamage;
        public short MaximumDamage
        {
            get { return maximumDamage; }
            set { maximumDamage = value; }
        }
        private bool isGoldOrMana;
        public bool IsGoldOrMana
        {
            get { return isGoldOrMana; }
            set { isGoldOrMana = value; }
        }
        private bool isIdentified;
        public bool IsIdentified
        {
            get { return isIdentified; }
            set
            {
                if (value == true)
                {
                    if (!this.Enchantments.Contains(0x20)) this.Enchantments.Add(0x20);
                }
                else
                {
                    if (this.Enchantments.Contains(0x20)) this.Enchantments.Remove(0x20);
                }
                isIdentified = value;
            }
        }
        public virtual void AssignToRoom(RoomLocation location)
        {
            this.Location = new RoomLocation(location.CurrentRoom.RoomID, location.X, location.Y, 0);
            this.Location.CurrentRoom = location.CurrentRoom;
        }
        public virtual void RemoveFromRoom()
        {
            this.Location = null;
        }
        public override byte[] Serialize(out uint id)
        {
            id = ServerGlobals.GetNextAvailableID();
            this.GameID = id;
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of naem
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            // right after name, if this item is engraved with a custom name
            // the spell byte is 0x4A
            if (!string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x4A);
            else w.WriteByte(0x00);
            // identified, added later ? yes
            // how to handle buffs ?
            if (this.Enchantments.Count == 0)
                w.WriteUShort(0x00);
            else
            {
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                    //Console.WriteLine("Wrote {0} for {1}.", b.ToString("X2"), this.GameID);
                }
            }
            w.WriteByte(0xFF); // buff end
            w.WriteByte(0x00); // i do not know if this byte holds a value
            // Roomlocation, if in a room
            #region Room and Location bytes
            if (this.Location == null) w.WriteByte(0x00); // no location
            else
            {
                if (this.Location.CurrentRoom != null)
                {
                    if (this.Location.CurrentRoom.RoomID <= 65535)
                    {
                        w.WriteByte(0x01);
                        w.WriteUShort((ushort)this.Location.CurrentRoom.RoomID);
                    }
                    else
                    {
                        w.WriteByte(0x02);
                        w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                    }
                    w.WriteUShort(this.Location.X);
                    w.WriteUShort(this.Location.Y);
                    w.WriteUShort(this.Location.Facing);
                }
                else w.WriteByte(0x00);// we do not know what happened, a locations room should never be null
            }
            // Ok locations done
            #endregion
            int i = this.IsInventoryItem ? 1 : 0;
            w.WriteByte((byte)i); // Not sure most items have this
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e);
            w.WriteByte(0x00); // Do not know
            // Starts info for containers
            if (this.IsContainer)
            {
                w.WriteShort((short)this.ContainedItems.Count);
                // Followed by items contained
            }
            else w.WriteShort(0x00);
          //  w.WriteByte(0x00);
            w.WriteUInt32(0x00);
            return w.GetRawPacket();
        }
        public virtual byte[] Serialize()
        {
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of naem
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            // right after name, if this item is engraved with a custom name
            // the spell byte is 0x4A
            if (!string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x4A);
            else w.WriteByte(0x00);
            // identified, added later ? yes
            // how to handle buffs ?
            if (this.Enchantments.Count == 0)
                w.WriteUShort(0x00);
            else
            {
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                    //Console.WriteLine("Wrote {0} for {1}.", b.ToString("X2"), this.GameID);
                }
            }
            w.WriteByte(0xFF); // buff end
            w.WriteByte(0x00); // i do not know if this byte holds a value
            // Roomlocation, if in a room
            #region Room and Location bytes
            if (this.Location == null) w.WriteByte(0x00); // no location
            else
            {
                if (this.Location.CurrentRoom != null)
                {
                    if (this.Location.CurrentRoom.RoomID <= 65535)
                    {
                        w.WriteByte(0x01);
                        w.WriteUShort((ushort)this.Location.CurrentRoom.RoomID);
                    }
                    else
                    {
                        w.WriteByte(0x02);
                        w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                    }
                    w.WriteUShort(this.Location.X);
                    w.WriteUShort(this.Location.Y);
                    w.WriteUShort(this.Location.Facing);
                }
                else w.WriteByte(0x00);// we do not know what happened, a locations room should never be null
            }
            // Ok locations done
            #endregion
            int i = this.IsInventoryItem ? 1 : 0;
            w.WriteByte((byte)i); // Not sure most items have this
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e);
            w.WriteByte(0x00); // Do not know
            // Starts info for containers
            if (this.IsContainer)
            {
                w.WriteShort((short)this.ContainedItems.Count);
                // Followed by items contained
            }
            else w.WriteShort(0x00);
            //  w.WriteByte(0x00);
            w.WriteUInt32(0x00);
            return w.GetRawPacket();
        }
        public override void Deserialize(byte[] data)
        {
        }
    }
}
