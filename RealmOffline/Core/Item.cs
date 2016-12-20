using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Packets;
using RealmOffline.Base;
using RealmOffline.Core.Items;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Core
{
    /*
     * Items are 20 bytes with no name change 
     * Armour is 21 bytes, same as item but with an equip byte
     * Weapons are 22 bytes, extra byte attacks per wepon maybe ?
     * Containers 24 bytes ?
     */
    public class Item: BaseGameItem, IComparable<Item>
    {
        public bool IsInRoom { get; private set; }
        public bool IsSlotIDAssigned = false;

        public override void AssignToRoom(RoomLocation location)
        {
            this.Location = new RoomLocation(location.CurrentRoom.RoomID, location.X, location.Y, 0);
            this.Location.CurrentRoom = location.CurrentRoom;
            this.IsInRoom = true;
        }
        public override void RemoveFromRoom()
        {
            this.Location = null;
            this.IsInRoom = false;
        }
        public void SetCharSlotID(uint id)
        {
            this.GameID = id;
           // Console.WriteLine("(SetCharSlotID):Set graphic id {0} to slotid {1}", this.GraphicID, this.ID);
            this.IsSlotIDAssigned = true;
        }
        /// <summary>
        /// The game knows what item types are by the
        /// graphical id for them, this is a ushort
        /// </summary>
        /// <param name="item">the item to compare</param>
        /// <returns>-1 if compare failed</returns>
        public int CompareTo(Item item)
        {
            if (this.GraphicID == item.GraphicID) { return 0; }
            else return -1;
        }

        public bool UpdateID(uint newID)
        {
            this.SetCharSlotID(newID);
            return true;
        }
        public static Item CastFromBaseItem(BaseGameItem item)
        {
            Item i = new Item();
            i.ContainedItems = item.ContainedItems;
            i.Enchantments = item.Enchantments;
            i.Equipped = item.Equipped;
            i.GameID = item.GameID;
            i.GraphicID = item.GraphicID;
            i.IsContainer = item.IsContainer;
            i.IsInRoom = item.Location != null;
            i.IsInventoryItem = item.IsInventoryItem;
            i.Color = item.Color;
            i.Name = item.Name;
            i.Location = item.Location;
            i.LookAt = item.LookAt;
            i.SqlID = item.SqlID;
            i.SqlOwnerID = item.SqlOwnerID;
            i.Type = item.Type;
            return i;
        }
        public override byte[] Serialize(out uint itemid)
        {
            // we want to turn this item into a game packet from a item
           PacketWriter w = new PacketWriter();
            w.WriteByte(1);
            w.WriteUShort(this.GraphicID);
            itemid = ServerGlobals.GetNextAvailableID();
            this.SetCharSlotID(itemid);
            //Console.WriteLine("(Serialize):Set item with graphic id of {0} to {1}", this.GraphicID, this.ID);
            w.WriteUInt32(itemid);
            w.WriteUShort(this.Color);
            if (!string.IsNullOrEmpty(this.Name))
            {
                w.WriteByte(1);
                w.WriteString(this.Name);
            }
            if (this.Enchantments.Count == 0)
                w.WriteUShort(0x00);
            else
            {
                w.WriteByte(0x00);
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                }
            }
            w.WriteByte(0xFF);
            if (this.IsGoldOrMana)
            {
                w.WriteByte(0x02);
                w.WriteInt32(this.Value);
            }

            else w.WriteByte(0x00);
            if (this.IsInRoom)
            {
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
                w.WriteShort(0x01);

            }
            else w.WriteByte(0x00); // if this has a value, than item is in a room
            int i = this.IsInventoryItem ? 1 : 0;
            w.WriteByte((byte)i);
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e); // not equiped
            w.WriteShort(0); // hmm ? stats ?
            w.WriteShort(0); // hmm ?
            //w.WriteShort(0);
            return w.GetRawPacket();
        }
        public override byte[] Serialize()
        {
            // we want to turn this item into a game packet from a item
            PacketWriter w = new PacketWriter();
            w.WriteByte(1);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color);

            if (!string.IsNullOrEmpty(this.Name))
            {
                w.WriteByte(1);
                w.WriteString(this.Name);

            }

                /*
                 * Noticed changes after name we have more bytes before 0xFF
                 * I assume by adding more bytes here, we add more spells.
                 * 0x20 adds if bought at store, then when i casted str with no enchant
                 * 0x00 = given or picked up loot ?
                 * 0x20 = store bought
                 * 0x4A = Engraved
                 * 0x27 = Casted Str
                 * 0x3B = casted dex, looks like it adds bytes as the were casted
                 * 0x16 = open enchant
                 * When you cast a spell on a item, it assigns the byte
                 * then saves in the item database that it is a temp buff
                 * because it saves the bytes just like it was enchanted
                 * or permed.
                 * 
                 */
            if (this.Enchantments.Count == 0)
                w.WriteUShort(0x00);
            else
            {
                w.WriteByte(0x00);
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                }
            }
            
            w.WriteByte(0xFF);
            w.WriteByte(0x00);
            if (this.IsInRoom)
            {
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
                w.WriteUShort(0x00);
            }
            else w.WriteByte(0x00); // if this has a value, than item is in a room
            int i = this.IsInventoryItem ? 1 : 0;
            w.WriteByte((byte)i); // think this is if its wearable ?
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e); // not equiped
            w.WriteByte(0x00);
            w.WriteByte(0x00);

            w.WriteByte(0x00); // crashed
            w.WriteByte(0x00); // adds talk to items

            w.WriteByte(0x00);
            w.WriteByte(0x00);
            return w.GetRawPacket();
        }
        public override void Deserialize(byte[] data)
        {

            // we want to turn this item from a gamepacket, into a item
            throw new NotImplementedException();
        }
    }
}
