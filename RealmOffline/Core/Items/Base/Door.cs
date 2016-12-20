using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace RealmOffline.Core.Items.Base
{
    public class Door : BaseGameItem
    {
        public bool IsOpen
        {
            get { return this.IsInventoryItem; }
            set { this.IsInventoryItem = value; }
        }
        public bool IsLocked { get; set; }
        public bool IsPickable { get; set; }
        public ushort KeyGraphicID { get; set; }
        public BaseGameItem SpecificKey { get; set; }
        public uint ExitRoom { get; set; }
        public ushort ExitWalkToX { get; set; }
        public ushort ExitWalkToY { get; set; }

        public static Door FromCode(ushort graphicID, uint roomNumber, ushort LocX, ushort LocY, 
            uint exitRoomNumber, ushort exitX, ushort exitY, Room inRoom, bool isOpen = false)
        {
            Door d = new Door();
            d.GraphicID = graphicID;
            d.GameID = ServerGlobals.GetNextAvailableID();
            d.IsContainer = isOpen;
            d.Location = new RoomLocation(roomNumber, LocX, LocY, 0);
            inRoom.RoomsIDsInUse.Add(d.GameID);
            d.Location.CurrentRoom = inRoom;
            d.ExitRoom = exitRoomNumber;
            d.ExitWalkToX = exitX;
            d.ExitWalkToY = exitY;
            d.LookAt = "You see a door.";
            return d;
        }
        public void LockDoor(BaseGameItem key = null)
        {
            if (key != null)
            {
                this.SpecificKey = key;
                this.IsPickable = true;
                this.IsLocked = true;
                this.IsOpen = false;
                this.LookAt = "A Locked door, the keyhole looks to have been used fairly recently.";
            }
            else
            {
                // A door that cannot be opened
                this.IsPickable = false;
                this.IsOpen = false;
                this.SpecificKey = null;
                this.IsLocked = true;
                this.LookAt = "A Locked door, the keyhole seems to be filled in with clay.";
            }
        }
        public void LockDoor(ushort keyGraphicId)
        {
            this.KeyGraphicID = keyGraphicId;
            this.IsPickable = true;
            this.IsLocked = true;
            this.IsOpen = false;
            this.LookAt = "A Locked door, the keyhole looks to be in good use.";
        }
        public bool UnlockDoor(BaseGameItem item = null)
        {
            if (item != null)
            {
                if (item == this.SpecificKey
                    || item.GameID == KeyGraphicID)
                {
                    // We got unlocked.
                    this.IsLocked = false;
                    this.LookAt = "A Unlocked door, it could lead anywhere.";
                    return true;
                }
            }
            return false;
        }
        public bool UnlockDoor()
        {
            // We got unlocked.
            this.IsLocked = false;
            this.LookAt = "A Unlocked door, it could lead anywhere.";
            return true;
        }
        public override byte[] Serialize()
        {
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            w.WriteByte(0x00); 
            w.WriteByte(0xFF); // buff end
            w.WriteByte(0x00); // i do not know if this byte holds a value
            // Roomlocation, if in a room
            #region Room and Location bytes
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
            // Ok locations done
            #endregion
            //int i = this.IsInventoryItem ? 1 : 0;
            w.WriteByte((byte)(this.IsInventoryItem ? 1 : 0)); // Not sure most items have this
            w.WriteByte((byte)(this.Equipped ? 1 : 0));
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            return w.GetRawPacket();
        }
    }
}
